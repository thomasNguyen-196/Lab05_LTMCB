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


namespace Lab05_LTMCB
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
        }

        private void Bai03_Load(object sender, EventArgs e)
        {
            tb_pass.PasswordChar = '*';

            lbl_status.Visible = false;
        }

        private bool CheckInputAndSend()
        {
            // Danh sách các trường cần kiểm tra
            string missingFields = "";

            if (string.IsNullOrWhiteSpace(tb_from.Text))
                missingFields += "- From\n";

            if (string.IsNullOrWhiteSpace(tb_rcp.Text))
                missingFields += "- Recipient (To)\n";

            if (string.IsNullOrWhiteSpace(tb_pass.Text))
                missingFields += "- Password\n";

            if (string.IsNullOrWhiteSpace(tb_subject.Text))
                missingFields += "- Subject\n";

            if (string.IsNullOrWhiteSpace(rtb_body.Text))
                missingFields += "- Body\n";

            // Kiểm tra nếu có trường bị bỏ trống
            if (!string.IsNullOrEmpty(missingFields))
            {
                // Thông báo cho người dùng nhập các trường còn thiếu
                MessageBox.Show(
                    "Vui lòng nhập đầy đủ các trường thông tin sau:\n" + missingFields,
                    "Thiếu thông tin",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return false;
            }

            return true;
        }

        private async void bt_send_Click(object sender, EventArgs e)
        {

            if (CheckInputAndSend())
            {
                bt_send.Enabled = false;
                bt_send.Visible = false;
                lbl_status.Visible = true;

                var mailMessage = new MailMessage
                {
                    From = new MailAddress($"{tb_from.Text}"),
                    Subject = tb_subject.Text,
                    Body = rtb_body.Text,      // Lấy nội dung từ rtb_body
                    IsBodyHtml = true
                };

                mailMessage.To.Add(tb_rcp.Text);

                var smtpServer = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential($"{tb_from.Text}", $"{tb_pass.Text}"),
                    EnableSsl = true
                };

                await smtpServer.SendMailAsync(mailMessage);

                bt_send.Visible = true;
                bt_send.Enabled = true;
                lbl_status.Visible = false;

                MessageBox.Show(
                    "Đã gửi mail của bạn thành công!",
                    "Thành công",
                    MessageBoxButtons.OK
                );
            } 
            else
            {
                return;
            }
        }
    }
}
