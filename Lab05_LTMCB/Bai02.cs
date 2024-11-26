﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit;
using MailKit.Net.Imap;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab05_LTMCB
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Tạo client IMAP
            using (var client = new ImapClient())
            {
                // Kết nối đến server IMAP (ví dụ: Gmail sử dụng imap.gmail.com, cổng 993)
                client.Connect("127.0.0.1", 993, true);

                // Đăng nhập với thông tin từ giao diện
                string email = tb_mail.Text;
                string password = tb_pass.Text;
                client.Authenticate(email, password);

                // Truy cập hộp thư "INBOX"
                var inbox = client.Inbox;
                inbox.Open(FolderAccess.ReadOnly);

                // Cấu hình ListView
                listView1.Columns.Add("Email", 200);
                listView1.Columns.Add("From", 100);
                listView1.Columns.Add("Thời gian", 100);
                listView1.View = View.Details;

                // Lấy danh sách email
                for (int i = 0; i < inbox.Count; i++)
                {
                    var message = inbox.GetMessage(i);
                    ListViewItem name = new ListViewItem(message.Subject);

                    // Thêm các thông tin vào cột
                    ListViewItem.ListViewSubItem from = new ListViewItem.ListViewSubItem(name, message.From.ToString());
                    ListViewItem.ListViewSubItem date = new ListViewItem.ListViewSubItem(name, message.Date.Date.ToString());

                    name.SubItems.Add(from);
                    name.SubItems.Add(date);

                    listView1.Items.Add(name);
                }

                // Ngắt kết nối
                client.Disconnect(true);

                MessageBox.Show("Đăng nhập và tải email thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
}
