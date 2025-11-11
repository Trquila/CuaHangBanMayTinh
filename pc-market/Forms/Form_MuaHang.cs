using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace pc_market.Forms
{
    public partial class Form_MuaHang : Form
    {
        private DataTable table;

        // Thông tin khách hàng gắn với user đăng nhập
        private string _maKhach = "";
        private string _tenKhach = "";
        private string _diaChi = "";
        private string _dienThoai = "";
        

        private decimal confirmedPrice = 0;

        public Form_MuaHang()
        {
            InitializeComponent();
            this.Load += FormMuaHang_Load;
            button1.Enabled = false;
            button2.Enabled = true;
        }

        public Form_MuaHang(string maKhach, string tenKhach, string diaChi, string dienThoai)
        {
            InitializeComponent();
            _maKhach = maKhach ?? "";
            _tenKhach = tenKhach ?? "";
            _diaChi = diaChi ?? "";
            _dienThoai = dienThoai ?? "";
            this.Load += FormMuaHang_Load;
        }

        private void FormMuaHang_Load(object sender, EventArgs e)
        {
            Classes.Functions.Connect();

            // Hiển thị sẵn thông tin KH (nếu có)
            if (!string.IsNullOrWhiteSpace(_tenKhach))
                txtTenkhach.Text = _tenKhach;
            if (!string.IsNullOrWhiteSpace(_diaChi))
                txtDiachi.Text = _diaChi;

            if (mskDienthoai != null)
            {
                string oldMask = mskDienthoai.Mask;
                try
                {
                    mskDienthoai.Mask = "";
                    mskDienthoai.Text = (_dienThoai ?? "").Trim();
                }
                finally
                {
                    // nếu muốn dùng lại định dạng mask:
                    // mskDienthoai.Mask = oldMask;
                }
            }

            if (pictureBox1 != null)
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            LoadDataGridView();

            // Khi chọn dòng/ô bất kỳ sẽ đổ dữ liệu lên khu vực "Thông tin máy"
            dataGridView1.CellClick += DataGridView1_CellOrSelectionChanged;
            dataGridView1.SelectionChanged += DataGridView1_CellOrSelectionChanged;
        }

        private void LoadDataGridView()
        {
            string query = @"
                SELECT  mayTinh.maMay, mayTinh.tenMay, loaiMay.tenLoaiMay, mainboard.tenMainboard, 
                        CPU.tenCPU, ram.tenRam, GPU.tenGPU, oCung.tenOC, manHinh.thongTin, hangSanXuat.tenHSX, 
                        mayTinh.giaNhap, mayTinh.giaBan, mayTinh.thoiGianBH, mayTinh.ghiChu 
                FROM mayTinh 
                LEFT JOIN loaiMay     ON mayTinh.maLoaiMay  = loaiMay.maLoaiMay 
                LEFT JOIN mainboard   ON mayTinh.maMainboard= mainboard.maMainboard 
                LEFT JOIN CPU         ON mayTinh.maCPU      = CPU.maCPU 
                LEFT JOIN ram         ON mayTinh.maRam      = ram.maRam 
                LEFT JOIN GPU         ON mayTinh.maGPU      = GPU.maGPU 
                LEFT JOIN oCung       ON mayTinh.maOC       = oCung.maOC 
                LEFT JOIN manHinh     ON mayTinh.maMH       = manHinh.maMH 
                LEFT JOIN hangSanXuat ON mayTinh.maHSX      = hangSanXuat.maHSX";

            table = Classes.Functions.GetDataToTable(query);
            dataGridView1.DataSource = table;

            // Cấu hình hiển thị bảng
            dataGridView1.Columns[0].HeaderText = "Mã máy tính";
            dataGridView1.Columns[1].HeaderText = "Tên máy tính";
            dataGridView1.Columns[2].HeaderText = "Loại máy";
            dataGridView1.Columns[3].HeaderText = "Mainboard";
            dataGridView1.Columns[4].HeaderText = "Vi xử lý";
            dataGridView1.Columns[5].HeaderText = "RAM";
            dataGridView1.Columns[6].HeaderText = "Card đồ họa";
            dataGridView1.Columns[7].HeaderText = "Ổ cứng";
            dataGridView1.Columns[8].HeaderText = "Màn hình";
            dataGridView1.Columns[9].HeaderText = "Hãng sản xuất";
            dataGridView1.Columns[10].HeaderText = "Giá nhập";
            dataGridView1.Columns[11].HeaderText = "Giá bán";
            dataGridView1.Columns[12].HeaderText = "Bảo hành (tháng)";
            dataGridView1.Columns[13].HeaderText = "Ghi chú";


            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Load combobox loại máy
            string cbQuery = "SELECT maLoaiMay, tenLoaiMay FROM loaiMay";
            DataTable typeTable = Classes.Functions.GetDataToTable(cbQuery);
            comboBox1.DataSource = typeTable;
            comboBox1.DisplayMember = "tenLoaiMay";
            comboBox1.ValueMember = "maLoaiMay";

            ResetValues();
        }

        private void ResetValues()
        {
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            richTextBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            if (pictureBox1 != null) pictureBox1.Image = null;
        }

        private void DataGridView1_CellOrSelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.Index < 0)
                return;

            var row = dataGridView1.CurrentRow;

            textBox2.Text = row.Cells[1].Value?.ToString() ?? "";   // Tên máy
            comboBox1.Text = row.Cells[2].Value?.ToString() ?? "";  // Loại máy
            textBox4.Text = row.Cells[11].Value?.ToString() ?? "";  // Giá bán
            textBox6.Text = row.Cells[12].Value?.ToString() ?? "";  // Bảo hành
            richTextBox1.Text = row.Cells[13].Value?.ToString() ?? ""; // Ghi chú

            if (pictureBox1 != null)
                pictureBox1.Image = null;
        }

        private readonly CultureInfo _viVN = CultureInfo.GetCultureInfo("vi-VN");
        private void button1_Click(object sender, EventArgs e)
        {   

            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một máy tính để mua.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maMay = dataGridView1.CurrentRow.Cells[0].Value?.ToString();
            if (string.IsNullOrWhiteSpace(maMay))
            {
                MessageBox.Show("Không xác định được mã máy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textBox5.Text.Trim(), out int soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Số lượng mua không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(textBox4.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal donGia))
            {
                MessageBox.Show("Giá bán không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            long thanhTien = (long)(donGia * soLuong);
            string maHDB = Classes.Functions.CreateKey("HDB");

            var conn = Classes.Functions.conn;
            using (SqlTransaction tran = conn.BeginTransaction())
            using (SqlCommand cmd = conn.CreateCommand())
            {
                cmd.Transaction = tran;
                try
                {
                    // 1. Ghi vào bảng hóa đơn bán (không có maNV)
                    cmd.CommandText = @"
                INSERT INTO dbo.hoaDonBan (maHDB, ngayBan, maKhach, tongTien)
                VALUES (@maHDB, CAST(GETDATE() AS date), @maKhach, @tongTien);";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@maHDB", maHDB);
                    cmd.Parameters.AddWithValue("@maKhach", _maKhach);
                    cmd.Parameters.AddWithValue("@tongTien", thanhTien);
                    cmd.ExecuteNonQuery();

                    // 2. Ghi vào bảng chi tiết hóa đơn
                    cmd.CommandText = @"
                INSERT INTO dbo.chiTietHDB (maHDB, maMay, soLuong, thanhTien)
                VALUES (@maHDB2, @maMay, @soLuong, @thanhTien);";   
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@maHDB2", maHDB);
                    cmd.Parameters.AddWithValue("@maMay", maMay);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                    cmd.ExecuteNonQuery();

                    // 3. Cập nhật tồn kho
                    cmd.CommandText = "UPDATE dbo.mayTinh SET soLuong = soLuong - @sl WHERE maMay = @maMay";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@sl", soLuong);
                    cmd.Parameters.AddWithValue("@maMay", maMay);
                    cmd.ExecuteNonQuery();

                    tran.Commit();

                    MessageBox.Show(
                        $"Đã mua hàng thành công!\nMã hóa đơn: {maHDB}\nTổng tiền: {thanhTien:N0} ₫",
                        "Thành công",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    // Sau khi lưu, bạn có thể reset form
                    ResetValues();
                    LoadDataGridView();
                }
                catch (Exception ex)
                {
                    try { tran.Rollback(); } catch { }
                    MessageBox.Show($"Lỗi khi lưu hóa đơn:\n{ex.Message}",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox4.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal giaBan) &&
                int.TryParse(textBox5.Text.Trim(), out int soLuong))
            {
                decimal tongTien = giaBan * soLuong;
                txtGia.Text = tongTien.ToString("N0", new CultureInfo("vi-VN"));
                button1.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giá và số lượng hợp lệ!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGia.Text = "0";
                button1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();  
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Classes.Functions.Connect();

            // Lấy mã hóa đơn mới nhất của khách hàng hiện tại
            string sql = $@"
                SELECT TOP 1 maHDB 
                FROM dbo.hoaDonBan 
                WHERE maKhach = '{_maKhach}' 
                ORDER BY ngayBan DESC, maHDB DESC";

            string maHDB = Classes.Functions.GetFieldValues(sql);

            if (string.IsNullOrWhiteSpace(maHDB))
            {
                MessageBox.Show("Khách hàng này chưa có hóa đơn nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Mở form hóa đơn khách hàng tương ứng
            var formHD = new Form_HoaDonKhachHang(maHDB);
            formHD.StartPosition = FormStartPosition.CenterScreen;

            this.Hide();           // Ẩn form mua hàng
            formHD.ShowDialog();   // Mở form hóa đơn
            this.Show();
        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
