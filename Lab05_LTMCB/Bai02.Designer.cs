namespace Lab05_LTMCB
{
    partial class Bai02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.total_tb = new System.Windows.Forms.TextBox();
            this.recent_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.mail_tb = new System.Windows.Forms.TextBox();
            this.pass_lbl = new System.Windows.Forms.Label();
            this.mail_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // total_tb
            // 
            this.total_tb.Location = new System.Drawing.Point(131, 91);
            this.total_tb.Name = "total_tb";
            this.total_tb.Size = new System.Drawing.Size(100, 20);
            this.total_tb.TabIndex = 20;
            // 
            // recent_tb
            // 
            this.recent_tb.Location = new System.Drawing.Point(338, 91);
            this.recent_tb.Name = "recent_tb";
            this.recent_tb.Size = new System.Drawing.Size(100, 20);
            this.recent_tb.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Recent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Total";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 313);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(97, 45);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(341, 20);
            this.pass_tb.TabIndex = 15;
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(638, 15);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(122, 49);
            this.bt_login.TabIndex = 14;
            this.bt_login.Text = "LOGIN";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // mail_tb
            // 
            this.mail_tb.Location = new System.Drawing.Point(97, 12);
            this.mail_tb.Name = "mail_tb";
            this.mail_tb.Size = new System.Drawing.Size(341, 20);
            this.mail_tb.TabIndex = 13;
            // 
            // pass_lbl
            // 
            this.pass_lbl.AutoSize = true;
            this.pass_lbl.Location = new System.Drawing.Point(21, 48);
            this.pass_lbl.Name = "pass_lbl";
            this.pass_lbl.Size = new System.Drawing.Size(53, 13);
            this.pass_lbl.TabIndex = 12;
            this.pass_lbl.Text = "Password";
            // 
            // mail_lbl
            // 
            this.mail_lbl.AutoSize = true;
            this.mail_lbl.Location = new System.Drawing.Point(21, 15);
            this.mail_lbl.Name = "mail_lbl";
            this.mail_lbl.Size = new System.Drawing.Size(32, 13);
            this.mail_lbl.TabIndex = 11;
            this.mail_lbl.Text = "Email";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total_tb);
            this.Controls.Add(this.recent_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.mail_tb);
            this.Controls.Add(this.pass_lbl);
            this.Controls.Add(this.mail_lbl);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox total_tb;
        private System.Windows.Forms.TextBox recent_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.TextBox mail_tb;
        private System.Windows.Forms.Label pass_lbl;
        private System.Windows.Forms.Label mail_lbl;
    }
}