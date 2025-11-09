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

            // Thiết lập xử lý sự kiện KeyDown cho cả hai textbox
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

        // Xử lý sự kiện KeyDown cho cả hai TextBox
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngăn tiếng "beep" khi nhấn Enter
                ButtonLogin_Click(sender, e); // Gọi hàm đăng nhập
            }
        }

        public void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (Classes.Functions.AccountValidate(username, password))
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form_Menu mainMenu = new Form_Menu();
                this.Hide();
                mainMenu.Show();
            }
            else
            {
                MessageBox.Show("Thông tin đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        public void ShowPassword_Checked(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
    }
}