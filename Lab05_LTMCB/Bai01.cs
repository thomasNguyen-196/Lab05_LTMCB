using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Lab05_LTMCB
{
    public partial class Bai01 : Form
    {

        public Bai01()
        {
            InitializeComponent();
        }

        private void snd_button_Click(object sender, EventArgs e)
        {
            using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
            {
                try
                {
                    // Lấy thông tin từ các TextBox
                    string mailFrom = from_tb.Text.ToString().Trim();
                    string mailTo = to_tb.Text.ToString().Trim();
                    string password = pass_tb.Text.ToString().Trim();

                    // Tạo thông tin đăng nhập
                    var basicCredential = new NetworkCredential(mailFrom, password);

                    // Tạo email message
                    using (MailMessage message = new MailMessage())
                    {
                        MailAddress fromAddress = new MailAddress(mailFrom);
                        message.From = fromAddress;
                        message.To.Add(mailTo);
                        message.Subject = Subject_tb.Text.ToString(); // Tiêu đề email
                        message.Body = body_rtb.Text.ToString(); // Nội dung email
                        message.IsBodyHtml = false; // Email không sử dụng HTML

                        // Cấu hình SmtpClient
                        smtpClient.UseDefaultCredentials = false;
                        smtpClient.Credentials = basicCredential;

                        // Gửi email
                        smtpClient.Send(message);

                        // Thông báo thành công
                        MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi nếu có
                    MessageBox.Show($"Gửi email thất bại! Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}
