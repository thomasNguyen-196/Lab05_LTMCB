namespace Lab05_LTMCB
{
    partial class Bai04_Send_Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai04_Send_Mail));
            this.lv_attachments = new System.Windows.Forms.ListView();
            this.lbl_attachments = new System.Windows.Forms.Label();
            this.ptb_attachments = new System.Windows.Forms.PictureBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.rtb_body = new System.Windows.Forms.RichTextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.tb_rcp = new System.Windows.Forms.TextBox();
            this.lbl_body = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_attachments)).BeginInit();
            this.SuspendLayout();
            // 
            // lv_attachments
            // 
            this.lv_attachments.HideSelection = false;
            this.lv_attachments.Location = new System.Drawing.Point(125, 345);
            this.lv_attachments.Name = "lv_attachments";
            this.lv_attachments.Size = new System.Drawing.Size(580, 122);
            this.lv_attachments.TabIndex = 29;
            this.lv_attachments.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_attachments
            // 
            this.lbl_attachments.AutoSize = true;
            this.lbl_attachments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attachments.Location = new System.Drawing.Point(22, 345);
            this.lbl_attachments.Name = "lbl_attachments";
            this.lbl_attachments.Size = new System.Drawing.Size(94, 17);
            this.lbl_attachments.TabIndex = 28;
            this.lbl_attachments.Text = "Attachments: ";
            // 
            // ptb_attachments
            // 
            this.ptb_attachments.ErrorImage = null;
            this.ptb_attachments.Image = ((System.Drawing.Image)(resources.GetObject("ptb_attachments.Image")));
            this.ptb_attachments.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptb_attachments.InitialImage")));
            this.ptb_attachments.Location = new System.Drawing.Point(731, 437);
            this.ptb_attachments.Name = "ptb_attachments";
            this.ptb_attachments.Size = new System.Drawing.Size(29, 30);
            this.ptb_attachments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_attachments.TabIndex = 27;
            this.ptb_attachments.TabStop = false;
            this.ptb_attachments.Click += new System.EventHandler(this.ptb_attachments_Click);
            // 
            // bt_send
            // 
            this.bt_send.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_send.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.Location = new System.Drawing.Point(311, 485);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(221, 98);
            this.bt_send.TabIndex = 25;
            this.bt_send.Text = "SEND";
            this.bt_send.UseVisualStyleBackColor = false;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // rtb_body
            // 
            this.rtb_body.Location = new System.Drawing.Point(125, 96);
            this.rtb_body.Name = "rtb_body";
            this.rtb_body.Size = new System.Drawing.Size(580, 228);
            this.rtb_body.TabIndex = 24;
            this.rtb_body.Text = "";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(125, 64);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(580, 20);
            this.tb_subject.TabIndex = 23;
            // 
            // tb_rcp
            // 
            this.tb_rcp.Location = new System.Drawing.Point(125, 38);
            this.tb_rcp.Name = "tb_rcp";
            this.tb_rcp.Size = new System.Drawing.Size(268, 20);
            this.tb_rcp.TabIndex = 21;
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(22, 96);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(47, 17);
            this.lbl_body.TabIndex = 19;
            this.lbl_body.Text = "Body: ";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(22, 64);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(61, 17);
            this.lbl_subject.TabIndex = 18;
            this.lbl_subject.Text = "Subject: ";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(22, 38);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(31, 17);
            this.lbl_to.TabIndex = 16;
            this.lbl_to.Text = "To: ";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(285, 526);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(268, 25);
            this.lbl_status.TabIndex = 26;
            this.lbl_status.Text = "Đang xử lý yêu cầu của bạn...";
            // 
            // Bai04_Send_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 630);
            this.Controls.Add(this.lv_attachments);
            this.Controls.Add(this.lbl_attachments);
            this.Controls.Add(this.ptb_attachments);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.rtb_body);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.tb_rcp);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_status);
            this.Name = "Bai04_Send_Mail";
            this.Text = "Bai04_Send_Mail";
            this.Load += new System.EventHandler(this.Bai04_Send_Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_attachments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_attachments;
        private System.Windows.Forms.Label lbl_attachments;
        private System.Windows.Forms.PictureBox ptb_attachments;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.RichTextBox rtb_body;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.TextBox tb_rcp;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_status;
    }
}