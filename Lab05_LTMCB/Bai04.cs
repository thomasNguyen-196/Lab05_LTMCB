using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_LTMCB
{
    public partial class Bai04 : Form
    {
        private ImapClient _imapClient;
        private string _username;
        private string _password;

        // Constructor nhận ImapClient, username và password
        public Bai04(ImapClient imapClient, string username, string password)
        {
            InitializeComponent();
            this._imapClient = imapClient;
            this._username = username;
            this._password = password;
        }

        private async void Bai04_Load(object sender, EventArgs e)
        {
            // Gọi phương thức LoadEmails mà không cần sử dụng CancellationToken
            await LoadEmails();
        }

        private void Bai04_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Khi form đóng, hiển thị lại form đăng nhập
            Bai04_Login loginForm = new Bai04_Login();
            loginForm.Show();
            this.Hide();  // Ẩn Bai04 để không thấy form này khi đóng
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Ẩn Bai04 và mở lại form đăng nhập
            Bai04_Login loginForm = new Bai04_Login();
            loginForm.Show();   // Hiển thị lại form đăng nhập
            this.Hide();        // Ẩn form Bai04 (form điều hướng)
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            // Xóa các thư đã tải trong ListView
            lv_mails.Items.Clear();

            // Gọi lại phương thức LoadEmails mà không cần sử dụng CancellationToken
            LoadEmails();
        }

        private async Task LoadEmails()
        {
            try
            {
                IMailFolder inbox = _imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly); // Mở hộp thư đến chỉ để đọc

                int mailCount = inbox.Count; // Số lượng thư trong inbox

                // Duyệt qua tất cả các thư trong inbox nhưng tải từng thư một
                for (int i = 0; i < mailCount; i++)
                {
                    MimeMessage message = await Task.Run(() => inbox.GetMessage(i)); // Tải thư bất đồng bộ
                    ListViewItem mail = new ListViewItem();
                    mail.Tag = message; // Lưu trữ message trong Tag để sử dụng sau này
                    mail.Text = (i + 1).ToString(); // Số thứ tự thư, i + 1 vì index bắt đầu từ 0
                    mail.SubItems.Add(message.From.ToString()); // Thêm người gửi
                    mail.SubItems.Add(message.Subject); // Thêm tiêu đề
                    mail.SubItems.Add(message.Date.ToString()); // Thêm ngày gửi
                    lv_mails.Items.Add(mail); // Thêm vào ListView

                    // Tạm dừng một chút để không làm giao diện bị đơ
                    await Task.Delay(100); // Thời gian delay giữa các thư (có thể điều chỉnh)

                    // Nếu số lượng thư quá nhiều, có thể thêm điều kiện để thoát sớm
                    if (i >= 50) // Ví dụ chỉ tải 50 thư đầu tiên để tránh quá tải
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thư: " + ex.Message);
            }
        }

        private void lv_mails_Click(object sender, EventArgs e)
        {
            Bai04_View_Mail item = new Bai04_View_Mail();
            item.Text = lv_mails.SelectedItems[0].SubItems[2].Text;
            item.Tag = lv_mails.SelectedItems[0].Tag;
            item.ShowDialog();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            Bai04_Send_Mail form = new Bai04_Send_Mail(_username, _password);
            form.ShowDialog();
        }
    }
}
