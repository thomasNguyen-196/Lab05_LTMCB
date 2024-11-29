using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_LTMCB
{
    public partial class Bai04 : Form
    {
        private ImapClient _imapClient;
        private string _username;
        private string _password;
        private SemaphoreSlim _imapSemaphore = new SemaphoreSlim(1, 1); // khai báo semaphore để đồng bộ hóa các tác vụ
        private CancellationTokenSource _cts = new CancellationTokenSource(); // Biến lưu trữ CancellationTokenSource


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
            await LoadEmails(_cts.Token);
        }

        private async void Bai04_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                // Đảm bảo không có tác vụ nào khác đang sử dụng ImapClient
                await _imapSemaphore.WaitAsync();

                if (_imapClient.IsConnected)
                {
                    _imapClient.Disconnect(true); // Đóng kết nối IMAP
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message);
            }
            finally
            {
                _imapSemaphore.Release(); // Giải phóng quyền truy cập
            }

            // Hiển thị lại form đăng nhập
            Bai04_Login loginForm = new Bai04_Login();
            loginForm.Show();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            // Ẩn Bai04 và mở lại form đăng nhập
            Bai04_Login loginForm = new Bai04_Login();
            loginForm.Show();   // Hiển thị lại form đăng nhập
            this.Close();        // Đóng form -> gọi sự kiện Form_Closing
        }

        private async void btn_Refresh_Click(object sender, EventArgs e)
        {
            // Hủy bỏ tác vụ đang chạy nếu có
            if (_cts != null && !_cts.Token.IsCancellationRequested)
            {
                _cts.Cancel();
            }

            // Tạo một CancellationTokenSource mới
            _cts = new CancellationTokenSource();

            try
            {
                if (_imapClient.IsConnected)
                {
                    // Gọi lại phương thức LoadEmails với CancellationToken mà không cần Semaphore trong sự kiện này
                    await LoadEmails(_cts.Token);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi refresh hộp thư: " + ex.Message);
            }
        }

        private async Task LoadEmails(CancellationToken cancellationToken)
        {
            try
            {
                await _imapSemaphore.WaitAsync(); // Đảm bảo truy cập an toàn

                IMailFolder inbox = _imapClient.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                int mailCount = inbox.Count;

                for (int i = 0; i < mailCount; i++)
                {
                    // Kiểm tra xem có yêu cầu hủy bỏ không
                    cancellationToken.ThrowIfCancellationRequested();

                    MimeMessage message = await Task.Run(() => inbox.GetMessage(i), cancellationToken);
                    ListViewItem mail = new ListViewItem
                    {
                        Tag = message,
                        Text = (i + 1).ToString()
                    };
                    mail.SubItems.Add(message.From.ToString());
                    mail.SubItems.Add(message.Subject);
                    mail.SubItems.Add(message.Date.ToString());
                    lv_mails.Items.Add(mail);

                    await Task.Delay(100); // Tránh làm giao diện bị đơ

                    if (i >= 50) break; // Chỉ tải 50 thư đầu tiên
                }
            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("Tải thư đã bị hủy.");
                lv_mails.Items.Clear(); // Xóa các thư đã tải trong ListView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải thư: " + ex.Message);
            }
            finally
            {
                _imapSemaphore.Release(); // Giải phóng quyền truy cập sau khi hoàn thành
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
