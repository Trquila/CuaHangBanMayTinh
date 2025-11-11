using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace pc_market.Forms
{
    public partial class Form_MenuKhachHang : Form
    {
        // Lưu thông tin khách hàng
        private string maKhach;
        private string tenKhach;
        private string diaChi;
        private string dienThoai;

        Form_MuaHang muaHang;
        Form_HoaDonKhachHang hoaDonKhachHang;

        // ✅ Constructor nhận đủ 4 tham số từ form đăng nhập
        public Form_MenuKhachHang(string maKhach, string tenKhach, string diaChi, string dienThoai)
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Cho phép chứa form con

            this.maKhach = maKhach;
            this.tenKhach = tenKhach;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
        }

        bool sidebarExpand = false;

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 30)
                {
                    sidebarExpand = false;
                    timerSidebar.Stop();
                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 135)
                {
                    sidebarExpand = true;
                    timerSidebar.Stop();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
            label2.Text = "Cửa hàng máy tính";
        }

        // ✅ Nút “Cửa hàng” → mở Form_MuaHang (và truyền thông tin khách hàng)
        private void button23_Click(object sender, EventArgs e)
        {
            if (muaHang == null)
            {
                muaHang = new Form_MuaHang(maKhach, tenKhach, diaChi, dienThoai);
                muaHang.FormClosed += muaHang_FormClosed;
                muaHang.MdiParent = this;
                muaHang.Dock = DockStyle.Fill;
                muaHang.Show();
            }
            else
            {
                muaHang.Activate();
            }
            label2.Text = "Cửa hàng máy tính";
        }

        private void muaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            muaHang = null;
        }

        // ✅ Nút “Hóa đơn của bạn” → mở Form_HoaDonKhachHang (theo mã khách)
        private void button4_Click(object sender, EventArgs e)
        {
            if (hoaDonKhachHang == null)
            {
                hoaDonKhachHang = new Form_HoaDonKhachHang(maKhach);
                hoaDonKhachHang.FormClosed += hoadonKH_FormClosed;
                hoaDonKhachHang.MdiParent = this;
                hoaDonKhachHang.Dock = DockStyle.Fill;
                hoaDonKhachHang.Show();
            }
            else
            {
                hoaDonKhachHang.Activate();
            }
            label2.Text = "Hóa đơn của bạn";
        }

        private void hoadonKH_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoaDonKhachHang = null;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Forms.Form_Exit formEx = new Forms.Form_Exit();
            formEx.StartPosition = FormStartPosition.CenterScreen;
            formEx.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Forms.Form_AboutUs formAboutus = new Forms.Form_AboutUs();
            formAboutus.StartPosition = FormStartPosition.CenterScreen;
            formAboutus.Show();
        }
    }
}
