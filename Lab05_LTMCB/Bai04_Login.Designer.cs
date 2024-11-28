namespace Lab05_LTMCB
{
    partial class Bai04_Login
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
            this.btn_Login = new System.Windows.Forms.Button();
            this.txt_Mat_Khau = new System.Windows.Forms.TextBox();
            this.txt_Tai_Khoan = new System.Windows.Forms.TextBox();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(377, 183);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(219, 43);
            this.btn_Login.TabIndex = 34;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // txt_Mat_Khau
            // 
            this.txt_Mat_Khau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mat_Khau.Location = new System.Drawing.Point(225, 145);
            this.txt_Mat_Khau.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mat_Khau.Name = "txt_Mat_Khau";
            this.txt_Mat_Khau.PasswordChar = '*';
            this.txt_Mat_Khau.ReadOnly = true;
            this.txt_Mat_Khau.Size = new System.Drawing.Size(371, 24);
            this.txt_Mat_Khau.TabIndex = 33;
            this.txt_Mat_Khau.Text = "ekhs wtxd lvhk upfo";
            // 
            // txt_Tai_Khoan
            // 
            this.txt_Tai_Khoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tai_Khoan.Location = new System.Drawing.Point(225, 94);
            this.txt_Tai_Khoan.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Tai_Khoan.Name = "txt_Tai_Khoan";
            this.txt_Tai_Khoan.ReadOnly = true;
            this.txt_Tai_Khoan.Size = new System.Drawing.Size(371, 24);
            this.txt_Tai_Khoan.TabIndex = 32;
            this.txt_Tai_Khoan.Text = "thomasspielberg5@gmail.com";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(99, 139);
            this.lbl_pass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(117, 30);
            this.lbl_pass.TabIndex = 31;
            this.lbl_pass.Text = "Password: ";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(96, 88);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(122, 30);
            this.lbl_username.TabIndex = 30;
            this.lbl_username.Text = "Username: ";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(380, 194);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(216, 20);
            this.lbl_status.TabIndex = 35;
            this.lbl_status.Text = "Đang xử lý yêu cầu của bạn...";
            // 
            // Bai04_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 345);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Mat_Khau);
            this.Controls.Add(this.txt_Tai_Khoan);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_status);
            this.Name = "Bai04_Login";
            this.Text = "Bai04_Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai04_Login_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txt_Mat_Khau;
        private System.Windows.Forms.TextBox txt_Tai_Khoan;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_status;
    }
}