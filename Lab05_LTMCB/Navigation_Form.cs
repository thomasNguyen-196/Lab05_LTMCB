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
    public partial class Navigation_Form : Form
    {
        public Navigation_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 newform = new Bai01();
            newform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 newForm = new Bai02();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bai03 newFrom = new Bai03();
            newFrom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04_Login newForm = new Bai04_Login();
            newForm.Show();
        }

        private void Navigation_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
