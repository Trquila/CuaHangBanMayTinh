using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace pc_market.Forms
{
    public partial class Form_MuaHang : Form
    {
        private DataTable table;

        public Form_MuaHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void FormMuaHang_Load(object sender, EventArgs e)
        {
            // Mở kết nối
            Classes.Functions.Connect();

            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

            // Gọi hàm load dữ liệu
            LoadDataGridView();
        }

        // 👉 Đặt lại tên hàm cho đúng chức năng
        private void LoadDataGridView()
        {
            string query = "SELECT mayTinh.maMay, mayTinh.tenMay, loaiMay.tenLoaiMay, mainboard.tenMainboard, CPU.tenCPU, ram.tenRam, GPU.tenGPU, oCung.tenOC, manHinh.thongTin, hangSanXuat.tenHSX, mayTinh.giaNhap, mayTinh.giaBan, mayTinh.soLuong, mayTinh.thoiGianBH, mayTinh.ghiChu " +
                           "FROM mayTinh " +
                           "LEFT JOIN loaiMay ON mayTinh.maLoaiMay = loaiMay.maLoaiMay " +
                           "LEFT JOIN mainboard ON mayTinh.maMainboard = mainboard.maMainboard " +
                           "LEFT JOIN CPU ON mayTinh.maCPU = CPU.maCPU " +
                           "LEFT JOIN ram ON mayTinh.maRam = ram.maRam " +
                           "LEFT JOIN GPU ON mayTinh.maGPU = GPU.maGPU " +
                           "LEFT JOIN oCung ON mayTinh.maOC = oCung.maOC " +
                           "LEFT JOIN manHinh ON mayTinh.maMH = manHinh.maMH " +
                           "LEFT JOIN hangSanXuat ON mayTinh.maHSX = hangSanXuat.maHSX";

            table = Classes.Functions.GetDataToTable(query);
            dataGridView1.DataSource = table;

            // Cấu hình cột
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
            dataGridView1.Columns[12].HeaderText = "Số lượng";
            dataGridView1.Columns[13].HeaderText = "Thời gian bảo hành";
            dataGridView1.Columns[14].HeaderText = "Ghi chú";

            // Đặt độ rộng
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 160;
            dataGridView1.Columns[4].Width = 160;
            dataGridView1.Columns[5].Width = 160;
            dataGridView1.Columns[6].Width = 160;
            dataGridView1.Columns[7].Width = 160;
            dataGridView1.Columns[8].Width = 200;
            dataGridView1.Columns[9].Width = 80;
            dataGridView1.Columns[10].Width = 100;
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[12].Width = 80;
            dataGridView1.Columns[13].Width = 80;
            dataGridView1.Columns[14].Width = 400;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;

            // Load dữ liệu cho combobox
            string typeComboBoxQuery = "SELECT maLoaiMay, tenLoaiMay FROM loaiMay";
            DataTable typeTable = Classes.Functions.GetDataToTable(typeComboBoxQuery);
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
            comboBox1.SelectedItem = null;
            pictureBox1.Image = null;
        }
    }
}
