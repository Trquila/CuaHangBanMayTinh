using System;
using System.Windows.Forms;

namespace pc_market.Forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        public void FormLogin_Load(object sender, EventArgs e)
        {
            Classes.Functions.Connect();

            // Gắn sự kiện KeyDown cho textbox
            textBox1.KeyDown += TextBox_KeyDown;
            textBox2.KeyDown += TextBox_KeyDown;
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                textBox2.Focus();
            }
        }

        // Xử lý nhấn phím Enter trong 2 textbox
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ButtonLogin_Click(sender, e); // Gọi nút đăng nhập
            }
        }

        public void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Kiểm tra tài khoản
            if (Classes.Functions.AccountValidate(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Kiểm tra checkbox để mở form tương ứng
                if (checkBox2.Checked) // Ví dụ: checkbox2 = Admin
                {
                    Form_Menu mainMenu = new Form_Menu();
                    this.Hide();
                    mainMenu.Show();
                }
                else if (checkBox3.Checked) // Ví dụ: checkbox3 = Khách hàng
                {
                    Form_MenuKhachHang khachMenu = new Form_MenuKhachHang();
                    this.Hide();
                    khachMenu.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn loại đăng nhập (Admin hoặc Khách hàng)!", 
                                    "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        // Ẩn / hiện mật khẩu
        public void ShowPassword_Checked(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu checkBox2 (Admin) được chọn, bỏ chọn checkBox3
            if (checkBox2.Checked)
                checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu checkBox3 (Khách hàng) được chọn, bỏ chọn checkBox2
            if (checkBox3.Checked)
                checkBox2.Checked = false;
        }
    }
}
