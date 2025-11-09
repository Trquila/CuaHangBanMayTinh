using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pc_market.Forms
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

       

        bool menuExpandTimKiem = false;
        private void timerTimKiem_Tick(object sender, EventArgs e)
        {
            if (menuExpandTimKiem == false)
            {
                timkiemContainer.Height += 10;
                if (timkiemContainer.Height >= 70) // mở ra 3 nút x 30px
                {
                    timerTimKiem.Stop();
                    menuExpandTimKiem = true;
                }
            }
            else
            {
                timkiemContainer.Height -= 10;
                if (timkiemContainer.Height <= 30) // thu gọn còn 1 nút
                {
                    timerTimKiem.Stop();
                    menuExpandTimKiem = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timerTimKiem.Start();
            label2.Text = "Tìm kiếm";
        }

        bool menuExpandHoaDon = false;

        private void timerHoaDon_Tick_1(object sender, EventArgs e)
        {
            if (menuExpandHoaDon == false)
            {
                hoadonContainer.Height += 10;
                if (hoadonContainer.Height >= 70) // mở ra 3 nút x 30px
                {
                    timerHoaDon.Stop();
                    menuExpandHoaDon = true;
                }
            }
            else
            {
                hoadonContainer.Height -= 10;
                if (hoadonContainer.Height <= 30) // thu gọn còn 1 nút
                {
                    timerHoaDon.Stop();
                    menuExpandHoaDon = false;
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            timerHoaDon.Start();
            label2.Text = "Hóa đơn";

        }

        bool menuExpandBaoCao = false;

        private void timerBaoCao_Tick(object sender, EventArgs e)
        {

            if (menuExpandBaoCao == false)
            {
                baocaoContainer.Height += 9;
                if (baocaoContainer.Height >= 94) // mở ra 3 nút x 30px
                {
                    timerBaoCao.Stop();
                    menuExpandBaoCao = true;
                }
            }
            else
            {
                baocaoContainer.Height -= 10;
                if (baocaoContainer.Height <= 30) // thu gọn còn 1 nút
                {
                    timerBaoCao.Stop();
                    menuExpandBaoCao = false;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            timerBaoCao.Start();
            label2.Text = "Báo cáo";

        }

        bool menuExpandLinhKien = false;

        private void timerLinhKien_Tick(object sender, EventArgs e)
        {
            if (menuExpandLinhKien == false)
            {
                linhkienContainer.Height += 10;
                if (linhkienContainer.Height >= 150) // mở ra 4 nút x 30px (hoặc 3 tùy bạn)
                {
                    timerLinhKien.Stop();
                    menuExpandLinhKien = true;
                }
            }
            else
            {
                linhkienContainer.Height -= 10;
                if (linhkienContainer.Height <= 30) // thu gọn còn 1 nút
                {
                    timerLinhKien.Stop();
                    menuExpandLinhKien = false;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            timerLinhKien.Start();
            label2.Text = "Linh kiện máy tính";

        }


        bool menuExpandThem = false;

        private void timerThem_Tick(object sender, EventArgs e)
        {
            if (menuExpandThem == false)
            {
                themContainer.Height += 10;
                if (themContainer.Height >= 70) // mở ra 4 nút x 30px (hoặc sửa lại 90 nếu chỉ 3 nút)
                {
                    timerThem.Stop();
                    menuExpandThem = true;
                }
            }
            else
            {
                themContainer.Height -= 10;
                if (themContainer.Height <= 30) // thu gọn còn 1 nút
                {
                    timerThem.Stop();
                    menuExpandThem = false;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timerThem.Start();
            label2.Text = "Thông tin thêm";

        }


        bool menuExpandDanhMuc = false;

        private void timerDanhMuc_Tick(object sender, EventArgs e)
        {
            if (menuExpandDanhMuc == false)
            {
                danhmucContainer.Height += 10;
                if (danhmucContainer.Height >= 115) // mở ra 4 nút x 30px (hoặc sửa thành 90 nếu 3 nút)
                {
                    timerDanhMuc.Stop();
                    menuExpandDanhMuc = true;
                }
            }
            else
            {
                danhmucContainer.Height -= 10;
                if (danhmucContainer.Height <= 30) // thu gọn còn 1 nút
                {
                    timerDanhMuc.Stop();
                    menuExpandDanhMuc = false;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            timerDanhMuc.Start();
            label2.Text = "Danh mục";

        }

        bool sidebarExpand = false;
        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 35)
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

        //Bien 
        Form_KhachHang khachhang;
        Form_BaoCaoBan baocaoban;
        Form_BaoCaoNhap baocaonhap;
        Form_CPU cpu;
        Form_DataStorage datastorage;
        Form_DoanhThu doanhthu;
        Form_GPU gpu;
        Form_HangSanXuat hangsanxuat;
        Form_HoaDonBan hoadonban;
        Form_HoaDonNhap hoadonnhap;
        Form_Mainboard mainboard;
        Form_Monitor monitor;
        Form_NCC ncc;
        Form_NhanVien nhanvien;
        Form_PC pc;
        Form_RAM ram;
        Form_SearchHDB searchHDB;
        Form_SearchHDN searchHDN;

        //PC
        private void button22_Click(object sender, EventArgs e)
        {
            if(pc == null)
            {
                pc = new Form_PC();
                pc.FormClosed += PC_FormClosed;
                pc.MdiParent = this;
                pc.Dock = DockStyle.Fill;
                pc.Show();
            }
            else
            {
                pc.Activate();
            }
            label2.Text = "Máy tính";

        }

        private void PC_FormClosed(object sender, FormClosedEventArgs e)
        {
            pc = null;
        }

        //NhanVien
        private void button23_Click(object sender, EventArgs e)
        {
            if (nhanvien == null)
            {
                nhanvien = new Form_NhanVien();
                nhanvien.FormClosed += NhanVien_FormClosed;
                nhanvien.MdiParent = this;
                nhanvien.Dock = DockStyle.Fill;
                nhanvien.Show();
            }
            else
            {
                nhanvien.Activate();
            }
            label2.Text = "Danh sách nhân viên";
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            nhanvien = null;
        }

        //KhachHang
        private void button25_Click(object sender, EventArgs e)
        {
            if (khachhang == null)
            {
                khachhang = new Form_KhachHang();
                khachhang.FormClosed += KhachHang_FormClosed;
                khachhang.MdiParent = this;
                khachhang.Dock = DockStyle.Fill;
                khachhang.Show();
            }
            else
            {
                khachhang.Activate();
            }
            label2.Text = "Danh sách khách hàng";

        }

        private void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            khachhang = null;
        }

        //NhaCungCap
        private void button26_Click(object sender, EventArgs e)
        {
            if (ncc == null)
            {
                ncc = new Form_NCC();
                ncc.FormClosed += NCC_FormClosed;
                ncc.MdiParent = this;
                ncc.Dock = DockStyle.Fill;
                ncc.Show();
            }
            else
            {
                ncc.Activate();
            }
            label2.Text = "Danh sách nhà cung cấp";
        }

        private void NCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            ncc = null;
        }

        //Monitor
        private void button17_Click(object sender, EventArgs e)
        {
            if (monitor == null)
            {          
                monitor = new Form_Monitor();
                monitor.FormClosed += Monitor_FormClosed;
                monitor.MdiParent = this;
                monitor.Dock = DockStyle.Fill;
                monitor.Show();
            }
            else
            {
                monitor.Activate();
            }
        }

        private void Monitor_FormClosed(object sender, FormClosedEventArgs e)
        {
            monitor = null;
        }

        //HangSanXuat
        private void button18_Click(object sender, EventArgs e)
        {
            if (hangsanxuat == null)
            {
                hangsanxuat = new Form_HangSanXuat();
                hangsanxuat.FormClosed += HSX_FormClosed;
                hangsanxuat.MdiParent = this;
                hangsanxuat.Dock = DockStyle.Fill;
                hangsanxuat.Show();
            }
            else
            {
                hangsanxuat.Activate();
            }
            label2.Text = "Danh sách hãng sản xuất";

        }

        private void HSX_FormClosed(object sender, FormClosedEventArgs e)
        {
            hangsanxuat = null;
        }

        //searchHoaDonNhap
        private void button2_Click(object sender, EventArgs e)
        {
            if (searchHDN == null)
            {
                searchHDN = new Form_SearchHDN();
                searchHDN.FormClosed += sHDN_FormClosed;
                searchHDN.MdiParent = this;
                searchHDN.Dock = DockStyle.Fill;
                searchHDN.Show();
            }
            else
            {
                searchHDN.Activate();
            }
        }

        private void sHDN_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchHDN = null;
        }

        //searchHoaDonBan
        private void button3_Click(object sender, EventArgs e)
        {
            if (searchHDB == null)
            {
                searchHDB = new Form_SearchHDB();
                searchHDB.FormClosed += sHDB_FormClosed;
                searchHDB.MdiParent = this;
                searchHDB.Dock = DockStyle.Fill;
                searchHDB.Show();
            }
            else
            {
                searchHDB.Activate();
            }
        }
        private void sHDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            searchHDB = null;
        }

        //BaoCaoNhap
        private void button8_Click(object sender, EventArgs e)
        {
            if (baocaonhap == null)
            {
                baocaonhap = new Form_BaoCaoNhap();
                baocaonhap.FormClosed += BCN_FormClosed;
                baocaonhap.MdiParent = this;
                baocaonhap.Dock = DockStyle.Fill;
                baocaonhap.Show();
            }
            else
            {
                baocaonhap.Activate();
            }
        }
        private void BCN_FormClosed(object sender, FormClosedEventArgs e)
        {
            baocaonhap = null;
        }

        //BaoCaoBan
        private void button9_Click(object sender, EventArgs e)
        {
            if (baocaoban == null)
            {
                baocaoban = new Form_BaoCaoBan();
                baocaoban.FormClosed += BCB_FormClosed;
                baocaoban.MdiParent = this;
                baocaoban.Dock = DockStyle.Fill;
                baocaoban.Show();
            }
            else
            {
                baocaoban.Activate();
            }
        }

        private void BCB_FormClosed(object sender, FormClosedEventArgs e)
        {
            baocaoban = null;
        }

        //DoanhThu
        private void button10_Click(object sender, EventArgs e)
        {
            if (doanhthu == null)
            {
                doanhthu = new Form_DoanhThu();
                doanhthu.FormClosed += DT_FormClosed;
                doanhthu.MdiParent = this;
                doanhthu.Dock = DockStyle.Fill;
                doanhthu.Show();
            }
            else
            {
                doanhthu.Activate();
            }
        }
        private void DT_FormClosed(object sender, FormClosedEventArgs e)
        {
            doanhthu = null;
        }

        //HoaDonBan
        private void button6_Click_1(object sender, EventArgs e)
        {
            if (hoadonban == null)
            {
                hoadonban = new Form_HoaDonBan();
                hoadonban.FormClosed += HDB_FormClosed;
                hoadonban.MdiParent = this;
                hoadonban.Dock = DockStyle.Fill;
                hoadonban.Show();
            }
            else
            {
                hoadonban.Activate();
            }
        }
        private void HDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoadonban = null;
        }

        //HoaDonNhap
        private void button5_Click(object sender, EventArgs e)
        {
            if (hoadonnhap == null)
            {
                hoadonnhap = new Form_HoaDonNhap();
                hoadonnhap.FormClosed += HDN_FormClosed;
                hoadonnhap.MdiParent = this;
                hoadonnhap.Dock = DockStyle.Fill;
                hoadonnhap.Show();
            }
            else
            {
                hoadonnhap.Activate();
            }
        }

        private void HDN_FormClosed(object sender, FormClosedEventArgs e)
        {
            hoadonnhap = null;
        }


        //Mainboard
        private void button12_Click(object sender, EventArgs e)
        {
            if (mainboard == null)
            {
                mainboard = new Form_Mainboard();
                mainboard.FormClosed += Main_FormClosed;
                mainboard.MdiParent = this;
                mainboard.Dock = DockStyle.Fill;
                mainboard.Show();
            }
            else
            {
                mainboard.Activate();
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainboard = null;
        }
        //CPU
        private void button13_Click(object sender, EventArgs e)
        {
            if (cpu == null)
            {
                cpu = new Form_CPU();
                cpu.FormClosed += CPU_FormClosed;
                cpu.MdiParent = this;
                cpu.Dock = DockStyle.Fill;
                cpu.Show();
            }
            else
            {
                cpu.Activate();
            }
        }

        private void CPU_FormClosed(object sender, FormClosedEventArgs e)
        {
            cpu = null;
        }

        //Ram
        private void button14_Click(object sender, EventArgs e)
        {
            if (ram == null)
            {
                ram = new Form_RAM();
                ram.FormClosed += RAM_FormClosed;
                ram.MdiParent = this;
                ram.Dock = DockStyle.Fill;
                ram.Show();
            }
            else
            {
                ram.Activate();
            }
        }

        private void RAM_FormClosed(object sender, FormClosedEventArgs e)
        {
            ram = null;
        }

        //GPU
        private void button15_Click(object sender, EventArgs e)
        {
            if (gpu == null)
            {
                gpu = new Form_GPU();
                gpu.FormClosed += GPU_FormClosed;
                gpu.MdiParent = this;
                gpu.Dock = DockStyle.Fill;
                gpu.Show();
            }
            else
            {
                gpu.Activate();
            }
        }
        private void GPU_FormClosed(object sender, FormClosedEventArgs e)
        {
            gpu = null;
        }

        //DataStorage
        private void button19_Click(object sender, EventArgs e)
        {
            if (datastorage == null)
            {
                datastorage = new Form_DataStorage();
                datastorage.FormClosed += DS_FormClosed;
                datastorage.MdiParent = this;
                datastorage.Dock = DockStyle.Fill;
                datastorage.Show();
            }
            else
            {
                datastorage.Activate();
            }
        }
        private void DS_FormClosed(object sender, FormClosedEventArgs e)
        {
            datastorage = null;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Forms.Form_AboutUs formAboutus = new Forms.Form_AboutUs();

            // Hiển thị form ở giữa màn hình
            formAboutus.StartPosition = FormStartPosition.CenterScreen;

            formAboutus.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Forms.Form_Exit formEx = new Forms.Form_Exit();

            // Hiển thị form ở giữa màn hình
            formEx.StartPosition = FormStartPosition.CenterScreen;

            formEx.Show();
        }
    }
}
