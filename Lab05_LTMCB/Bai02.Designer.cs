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
            this.listView1 = new System.Windows.Forms.ListView();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.Label();
            this.mail_tb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(753, 303);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(98, 56);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.Size = new System.Drawing.Size(341, 20);
            this.tb_pass.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(98, 23);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(341, 20);
            this.tb_mail.TabIndex = 9;
            // 
            // pass_tb
            // 
            this.pass_tb.AutoSize = true;
            this.pass_tb.Location = new System.Drawing.Point(22, 59);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(53, 13);
            this.pass_tb.TabIndex = 8;
            this.pass_tb.Text = "Password";
            // 
            // mail_tb
            // 
            this.mail_tb.AutoSize = true;
            this.mail_tb.Location = new System.Drawing.Point(22, 26);
            this.mail_tb.Name = "mail_tb";
            this.mail_tb.Size = new System.Drawing.Size(32, 13);
            this.mail_tb.TabIndex = 7;
            this.mail_tb.Text = "Email";
            // 
            // Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_mail);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.mail_tb);
            this.Name = "Bai02";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label pass_tb;
        private System.Windows.Forms.Label mail_tb;
    }
}