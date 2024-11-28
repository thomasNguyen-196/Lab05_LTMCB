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
    public partial class Bai04_View_Mail : Form
    {
        public Bai04_View_Mail()
        {
            InitializeComponent();
        }

        private void Bai04_View_Mail_Load(object sender, EventArgs e)
        {
            MimeMessage message = Tag as MimeMessage;
            txt_From.Text = message.From.ToString();
            Text = message.Subject;
            txt_To.Text = message.To.ToString();
            txt_Subject.Text = message.Subject;
            txt_Mail_Content.DocumentText = message.HtmlBody;
        }
    }
}
