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
using System.IO;


namespace Lab05_LTMCB
{
    public partial class Bai03 : Form
    {
        public Bai03()
        {
            InitializeComponent();
            InitializeListView();
        }

        private void InitializeListView()
        {
            // Cấu hình ListView
            lv_attachments.View = View.SmallIcon; // Chế độ hiển thị icon nhỏ
            lv_attachments.SmallImageList = imageList; // Gắn ImageList
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

            if (string.IsNullOrWhiteSpace(tb_rcp.Text))
                missingFields += "- Recipient (To)\n";

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

            // Kiểm tra độ hợp lệ của địa chỉ email
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(tb_rcp.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show(
                    "Địa chỉ email không hợp lệ. Vui lòng nhập đúng định dạng email.",
                    "Email không hợp lệ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
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
                    Body = rtb_body.Text, // Lấy nội dung từ rtb_body
                    IsBodyHtml = true
                };

                mailMessage.To.Add(tb_rcp.Text);

                try
                {
                    // Đính kèm file không đồng bộ
                    await AddAttachmentsAsync(mailMessage, attachedFiles);

                    var smtpServer = new SmtpClient("smtp.gmail.com")
                    {
                        Port = 587,
                        Credentials = new NetworkCredential($"{tb_from.Text}", $"{tb_pass.Text}"),
                        EnableSsl = true
                    };

                    // Gửi mail không đồng bộ
                    await smtpServer.SendMailAsync(mailMessage);

                    MessageBox.Show("Đã gửi mail của bạn thành công!", "Thành công", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Gửi mail không thành công: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bt_send.Visible = true;
                    bt_send.Enabled = true;
                    lbl_status.Visible = false;

                    ClearAllFields();
                }
            }
        }

        private async Task AddAttachmentsAsync(MailMessage mailMessage, List<string> attachedFiles)
        {
            await Task.Run(() =>
            {
                foreach (var filePath in attachedFiles)
                {
                    try
                    {
                        Attachment attachment = new Attachment(filePath);
                        mailMessage.Attachments.Add(attachment);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Lỗi khi đính kèm file: {filePath}\n{ex.Message}");
                    }
                }
            });
        }

        private List<string> attachedFiles = new List<string>(); // Danh sách đường dẫn file đính kèm
        private void ptb_attachments_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files|*.*";
                openFileDialog.Title = "Select files to attach";
                openFileDialog.Multiselect = true; // Cho phép chọn nhiều file
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        if (!attachedFiles.Contains(filePath)) // Tránh đính kèm trùng lặp
                        {
                            attachedFiles.Add(filePath);

                            // Lấy index icon
                            int imageIndex = GetImageIndexForFile(filePath);

                            // Thêm vào ListView
                            lv_attachments.Items.Add(new ListViewItem
                            {
                                Text = Path.GetFileName(filePath),
                                ImageIndex = imageIndex,
                                ToolTipText = filePath // Hiển thị đường dẫn đầy đủ khi hover
                            });
                        }
                    }
                }
            }
        }

        private void ClearAllFields()
        {
            // Xóa nội dung trong các TextBox
            tb_rcp.Clear();
            tb_subject.Clear();
            rtb_body.Clear();

            // Xóa danh sách các file đính kèm
            attachedFiles.Clear();
            clearAttachments();
        }

        private void clearAttachments()
        {
            attachedFiles.Clear();
            lv_attachments.Items.Clear();
            extensionImageIndex.Clear();
            imageList.Images.Clear();
        }

        private ImageList imageList = new ImageList();
        private Dictionary<string, int> extensionImageIndex = new Dictionary<string, int>();

        private int GetImageIndexForFile(string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLower();

            // Nếu extension đã có trong dictionary thì trả về index đã lưu
            if (extensionImageIndex.ContainsKey(extension))
            {
                return extensionImageIndex[extension];
            }

            try
            {
                // Lấy icon cho loại file
                Icon icon = Icon.ExtractAssociatedIcon(filePath);
                if (icon != null)
                {
                    imageList.Images.Add(extension, icon);
                    int index = imageList.Images.Count - 1;
                    extensionImageIndex[extension] = index;
                    return index;
                }
            }
            catch
            {
                // Nếu không lấy được icon, trả về 0 (icon mặc định)
                return 0;
            }

            return 0;
        }
    }
}
