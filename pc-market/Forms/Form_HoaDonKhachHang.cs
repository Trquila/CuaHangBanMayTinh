using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace pc_market.Forms
{
    public partial class Form_HoaDonKhachHang : Form
    {
        private readonly string _maHDB;
        private readonly string _maKhach;   // có thể rỗng, sẽ suy ra từ hóa đơn

        // Nhận mỗi mã hóa đơn (sẽ suy ra mã khách)
        public Form_HoaDonKhachHang(string maHDB)
        {
            InitializeComponent();
            _maHDB = maHDB ?? "";
            _maKhach = "";                  // chưa biết, sẽ lấy sau từ header
            this.Load += Form_HoaDonKhachHang_Load;
        }

        // Nhận cả mã hóa đơn và mã khách (nếu form trước đã có)
        public Form_HoaDonKhachHang(string maHDB, string maKhach)
        {
            InitializeComponent();
            _maHDB = maHDB ?? "";
            _maKhach = maKhach ?? "";
            this.Load += Form_HoaDonKhachHang_Load;
        }

        private void Form_HoaDonKhachHang_Load(object sender, EventArgs e)
        {
            Classes.Functions.Connect();

            if (string.IsNullOrWhiteSpace(_maHDB))
            {
                MessageBox.Show("Không có mã hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 1) Nạp chi tiết hóa đơn hiện tại
            LoadInvoice(_maHDB);

            // 2) Lấy maKhach để nạp lịch sử hóa đơn
            string maKhachToLoad = !string.IsNullOrWhiteSpace(_maKhach)
                ? _maKhach.Trim()
                : (txtMaKhach.Text ?? "").Trim();

            if (!string.IsNullOrWhiteSpace(maKhachToLoad))
                LoadInvoicesByKhach(maKhachToLoad);
        }

        private void LoadInvoice(string maHDB)
        {
            // --- Header: hoaDonBan + khachHang
            string sqlHeader = @"
                SELECT h.maHDB, h.ngayBan, h.maKhach, k.tenKhach, k.diaChi, k.dienThoai, h.tongTien
                FROM dbo.hoaDonBan AS h
                JOIN dbo.khachHang AS k ON k.maKhach = h.maKhach
                WHERE h.maHDB = @maHDB";

            using (var cmd = new SqlCommand(sqlHeader, Classes.Functions.conn))
            {
                cmd.Parameters.AddWithValue("@maHDB", maHDB);
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        txtMaHDB.Text = r["maHDB"].ToString();
                        mskNgayBan.Text = Convert.ToDateTime(r["ngayBan"]).ToString("dd/MM/yyyy");
                        txtMaKhach.Text = r["maKhach"].ToString();
                        txtTenKhach.Text = r["tenKhach"].ToString();
                        txtDiaChi.Text = r["diaChi"].ToString();
                        txtDienThoai.Text = r["dienThoai"].ToString();

                        var tong = Convert.ToDecimal(r["tongTien"]);
                        txtTongTien.Text = tong.ToString("N0", CultureInfo.InvariantCulture);
                        // lblTongTienChu.Text = Classes.Functions.ConvertNumericToText(tong.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }

            // --- Chi tiết: (form hiện tại hiển thị một dòng). Nếu muốn nhiều dòng, thay bằng DataGridView riêng.
            string sqlDetail = @"
                SELECT TOP(1) c.maMay, m.tenMay, m.giaBan, c.soLuong, c.thanhTien, m.thoiGianBH
                FROM dbo.chiTietHDB AS c
                JOIN dbo.mayTinh   AS m ON m.maMay = c.maMay
                WHERE c.maHDB = @maHDB
                ORDER BY c.maMay";

            using (var cmd = new SqlCommand(sqlDetail, Classes.Functions.conn))
            {
                cmd.Parameters.AddWithValue("@maHDB", maHDB);
                using (var r = cmd.ExecuteReader())
                {
                    if (r.Read())
                    {
                        txtTenMay.Text = r["tenMay"].ToString();
                        txtDonGia.Text = Convert.ToDecimal(r["giaBan"]).ToString("N0", CultureInfo.InvariantCulture);
                        txtSoLuong.Text = r["soLuong"].ToString();
                        txtThanhTien.Text = Convert.ToDecimal(r["thanhTien"]).ToString("N0", CultureInfo.InvariantCulture);
                        txtBaoHanh.Text = r["thoiGianBH"] == DBNull.Value ? "0" : r["thoiGianBH"].ToString();
                    }
                    else
                    {
                        // Hóa đơn không có chi tiết
                        txtTenMay.Clear();
                        txtDonGia.Clear();
                        txtSoLuong.Clear();
                        txtThanhTien.Clear();
                        txtBaoHanh.Clear();
                    }
                }
            }
        }

        /// <summary>
        /// Nạp lịch sử toàn bộ hóa đơn theo mã khách lên DataGridView dgvHoaDon
        /// </summary>
        private void LoadInvoicesByKhach(string maKhach)
        {
            string sql = @"
                SELECT 
                    h.maHDB,
                    h.ngayBan,
                    COUNT(ct.maMay)         AS SoMatHang,
                    SUM(ct.soLuong)         AS TongSoLuong,
                    h.tongTien
                FROM dbo.hoaDonBan AS h
                LEFT JOIN dbo.chiTietHDB AS ct ON ct.maHDB = h.maHDB
                WHERE h.maKhach = @maKhach
                GROUP BY h.maHDB, h.ngayBan, h.tongTien
                ORDER BY h.ngayBan DESC, h.maHDB DESC";

            using (var cmd = new SqlCommand(sql, Classes.Functions.conn))
            {
                cmd.Parameters.AddWithValue("@maKhach", maKhach);
                using (var ad = new SqlDataAdapter(cmd))
                {
                    var tb = new DataTable();
                    ad.Fill(tb);
                    dgvHoaDon.DataSource = tb;
                }
            }

            // Cấu hình lưới
            if (dgvHoaDon.Columns.Count > 0)
            {
                dgvHoaDon.AutoGenerateColumns = true;
                dgvHoaDon.ReadOnly = true;
                dgvHoaDon.AllowUserToAddRows = false;
                dgvHoaDon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvHoaDon.MultiSelect = false;

                if (dgvHoaDon.Columns["maHDB"] != null)
                    dgvHoaDon.Columns["maHDB"].HeaderText = "Mã HĐ";
                if (dgvHoaDon.Columns["ngayBan"] != null)
                {
                    dgvHoaDon.Columns["ngayBan"].HeaderText = "Ngày bán";
                    dgvHoaDon.Columns["ngayBan"].DefaultCellStyle.Format = "dd/MM/yyyy";
                }
                if (dgvHoaDon.Columns["SoMatHang"] != null)
                {
                    dgvHoaDon.Columns["SoMatHang"].HeaderText = "Số mặt hàng";
                    dgvHoaDon.Columns["SoMatHang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvHoaDon.Columns["TongSoLuong"] != null)
                {
                    dgvHoaDon.Columns["TongSoLuong"].HeaderText = "Tổng SL";
                    dgvHoaDon.Columns["TongSoLuong"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                }
                if (dgvHoaDon.Columns["tongTien"] != null)
                {
                    dgvHoaDon.Columns["tongTien"].HeaderText = "Tổng tiền";
                    dgvHoaDon.Columns["tongTien"].DefaultCellStyle.Format = "N0";
                    dgvHoaDon.Columns["tongTien"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }

                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

            // Double-click để mở lại chi tiết hóa đơn đó (nếu muốn)
            dgvHoaDon.CellDoubleClick -= dgvHoaDon_CellDoubleClick;
            dgvHoaDon.CellDoubleClick += dgvHoaDon_CellDoubleClick;
        }

        private void dgvHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvHoaDon.Rows[e.RowIndex].Cells["maHDB"]?.Value != null)
            {
                string maHDB = dgvHoaDon.Rows[e.RowIndex].Cells["maHDB"].Value.ToString();
                if (!string.IsNullOrWhiteSpace(maHDB))
                {
                    var f = new Form_HoaDonKhachHang(maHDB);
                    f.StartPosition = FormStartPosition.CenterScreen;
                    f.ShowDialog();
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
