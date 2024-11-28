using MailKit;
using MailKit.Net.Imap;
using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_LTMCB
{
    public partial class Bai04_Login : Form
    {
        public Bai04_Login()
        {
            InitializeComponent();

            lbl_status.Visible = false;
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                btn_Login.Enabled = false;
                btn_Login.Visible = false;

                lbl_status.Visible = true;

                string server = "imap.gmail.com";
                int port = 993;
                string username = txt_Tai_Khoan.Text;
                string password = txt_Mat_Khau.Text;

                var client = new MailKit.Net.Imap.ImapClient();

                // Thiết lập kết nối và xác thực
                await Task.Run(() =>
                {
                    client.Connect(server, port, true); // Kết nối qua SSL
                    client.Authenticate(username, password); // Xác thực
                });

                // Nếu xác thực thành công, mở form Bai04 và truyền ImapClient, username và password vào constructor
                Bai04 bai04Form = new Bai04(client, username, password);
                bai04Form.Show();
                this.Hide();
            }
            catch (MailKit.Security.AuthenticationException ex)
            {
                MessageBox.Show("Xác thực không thành công: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally 
            {
                lbl_status.Visible = false;

                btn_Login.Visible = true;
                btn_Login.Enabled = true;
            }
        }

        private void Bai04_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu form đăng nhập bị đóng, thoát ứng dụng
            this.Hide();
        }
    }
}
