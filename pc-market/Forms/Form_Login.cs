using System;
using System.Data.SqlClient;
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
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra checkbox để mở form tương ứng
            if (checkBox2.Checked) // Tài khoản Admin
            {
                if (Classes.Functions.AccountValidate(username, password))
                {
                    MessageBox.Show("Đăng nhập Admin thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form_Menu mainMenu = new Form_Menu();
                    this.Hide();
                    mainMenu.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu Admin không đúng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            else if (checkBox3.Checked) // Tài khoản Khách hàng
            {
                var info = GetUserAndCustomerInfo(username, password);
                if (info.isValid)
                {
                    MessageBox.Show("Đăng nhập Khách hàng thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở form mua hàng và truyền thông tin KH để auto điền
                    var menuKh = new Form_MenuKhachHang(info.maKhach, info.tenKhach, info.diaChi, info.dienThoai);
                    this.Hide();
                    menuKh.Show();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu Khách hàng không đúng!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại đăng nhập (Admin hoặc Khách hàng)!", "Chú ý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Lấy thông tin user + khách hàng theo Username/Password
        // Trả về: hợp lệ?, maKhach, tenKhach, diaChi, dienThoai
        private (bool isValid, string maKhach, string tenKhach, string diaChi, string dienThoai)
            GetUserAndCustomerInfo(string username, string password)
        {
            try
            {
                if (Classes.Functions.conn == null ||
                    Classes.Functions.conn.State != System.Data.ConnectionState.Open)
                {
                    Classes.Functions.Connect();
                }

                string sql = @"
                    SELECT U.maKhach, K.tenKhach, K.diaChi, K.dienThoai
                    FROM Users U
                    JOIN khachHang K ON K.maKhach = U.maKhach
                    WHERE U.Username = @u AND U.[Password] = @p";

                using (SqlCommand cmd = new SqlCommand(sql, Classes.Functions.conn))
                {
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            return (
                                true,
                                r["maKhach"].ToString(),
                                r["tenKhach"].ToString(),
                                r["diaChi"].ToString(),
                                r["dienThoai"].ToString()
                            );
                        }
                        else
                        {
                            return (false, "", "", "", "");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin khách hàng:\n" + ex.Message,
                    "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false, "", "", "", "");
            }
        }

        // Ẩn / hiện mật khẩu
        public void ShowPassword_Checked(object sender, EventArgs e)
        {
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) checkBox3.Checked = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) checkBox2.Checked = false;
        }
    }
}
