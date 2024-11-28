namespace Lab05_LTMCB
{
    partial class Bai04
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
            this.lv_mails = new System.Windows.Forms.ListView();
            this.No_of_mail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Send = new System.Windows.Forms.Button();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_mails
            // 
            this.lv_mails.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lv_mails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No_of_mail,
            this.Source,
            this.Title,
            this.Time});
            this.lv_mails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_mails.FullRowSelect = true;
            this.lv_mails.HideSelection = false;
            this.lv_mails.Location = new System.Drawing.Point(45, 93);
            this.lv_mails.Margin = new System.Windows.Forms.Padding(2);
            this.lv_mails.Name = "lv_mails";
            this.lv_mails.Size = new System.Drawing.Size(1179, 499);
            this.lv_mails.TabIndex = 33;
            this.lv_mails.UseCompatibleStateImageBehavior = false;
            this.lv_mails.View = System.Windows.Forms.View.Details;
            this.lv_mails.Click += new System.EventHandler(this.lv_mails_Click);
            // 
            // No_of_mail
            // 
            this.No_of_mail.Text = "#";
            // 
            // Source
            // 
            this.Source.Text = "From";
            this.Source.Width = 432;
            // 
            // Title
            // 
            this.Title.Text = "Subject";
            this.Title.Width = 372;
            // 
            // Time
            // 
            this.Time.Text = "Datetime";
            this.Time.Width = 293;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1001, 35);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(223, 43);
            this.btn_Refresh.TabIndex = 32;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Send
            // 
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.Location = new System.Drawing.Point(764, 35);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(219, 43);
            this.btn_Send.TabIndex = 31;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // btn_Logout
            // 
            this.btn_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Logout.Location = new System.Drawing.Point(1005, 614);
            this.btn_Logout.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(219, 43);
            this.btn_Logout.TabIndex = 30;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 682);
            this.Controls.Add(this.lv_mails);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.btn_Logout);
            this.Name = "Bai04";
            this.Text = "Bai04";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bai04_FormClosing);
            this.Load += new System.EventHandler(this.Bai04_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_mails;
        private System.Windows.Forms.ColumnHeader No_of_mail;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Button btn_Logout;
    }
}