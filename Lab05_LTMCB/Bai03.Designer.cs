﻿namespace Lab05_LTMCB
{
    partial class Bai03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai03));
            this.lbl_from = new System.Windows.Forms.Label();
            this.lbl_to = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.lbl_body = new System.Windows.Forms.Label();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.tb_rcp = new System.Windows.Forms.TextBox();
            this.tb_pass = new System.Windows.Forms.TextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.rtb_body = new System.Windows.Forms.RichTextBox();
            this.bt_send = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.ptb_attachments = new System.Windows.Forms.PictureBox();
            this.lbl_attachments = new System.Windows.Forms.Label();
            this.lv_attachments = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_attachments)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_from.Location = new System.Drawing.Point(112, 35);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(48, 17);
            this.lbl_from.TabIndex = 0;
            this.lbl_from.Text = "From: ";
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_to.Location = new System.Drawing.Point(112, 71);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(31, 17);
            this.lbl_to.TabIndex = 1;
            this.lbl_to.Text = "To: ";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.Location = new System.Drawing.Point(525, 35);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(74, 17);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Password: ";
            // 
            // lbl_subject
            // 
            this.lbl_subject.AutoSize = true;
            this.lbl_subject.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(12, 110);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(61, 17);
            this.lbl_subject.TabIndex = 3;
            this.lbl_subject.Text = "Subject: ";
            // 
            // lbl_body
            // 
            this.lbl_body.AutoSize = true;
            this.lbl_body.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_body.Location = new System.Drawing.Point(12, 142);
            this.lbl_body.Name = "lbl_body";
            this.lbl_body.Size = new System.Drawing.Size(47, 17);
            this.lbl_body.TabIndex = 4;
            this.lbl_body.Text = "Body: ";
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(155, 35);
            this.tb_from.Name = "tb_from";
            this.tb_from.ReadOnly = true;
            this.tb_from.Size = new System.Drawing.Size(268, 20);
            this.tb_from.TabIndex = 5;
            this.tb_from.Text = "thomasspielberg5@gmail.com";
            // 
            // tb_rcp
            // 
            this.tb_rcp.Location = new System.Drawing.Point(155, 71);
            this.tb_rcp.Name = "tb_rcp";
            this.tb_rcp.Size = new System.Drawing.Size(268, 20);
            this.tb_rcp.TabIndex = 6;
            // 
            // tb_pass
            // 
            this.tb_pass.Location = new System.Drawing.Point(595, 35);
            this.tb_pass.Name = "tb_pass";
            this.tb_pass.PasswordChar = '*';
            this.tb_pass.ReadOnly = true;
            this.tb_pass.Size = new System.Drawing.Size(100, 20);
            this.tb_pass.TabIndex = 7;
            this.tb_pass.Text = "ekhs wtxd lvhk upfo";
            // 
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(115, 110);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(580, 20);
            this.tb_subject.TabIndex = 8;
            // 
            // rtb_body
            // 
            this.rtb_body.Location = new System.Drawing.Point(115, 142);
            this.rtb_body.Name = "rtb_body";
            this.rtb_body.Size = new System.Drawing.Size(580, 228);
            this.rtb_body.TabIndex = 9;
            this.rtb_body.Text = "";
            // 
            // bt_send
            // 
            this.bt_send.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_send.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_send.Location = new System.Drawing.Point(301, 531);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(221, 98);
            this.bt_send.TabIndex = 10;
            this.bt_send.Text = "SEND";
            this.bt_send.UseVisualStyleBackColor = false;
            this.bt_send.Click += new System.EventHandler(this.bt_send_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(275, 572);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(268, 25);
            this.lbl_status.TabIndex = 11;
            this.lbl_status.Text = "Đang xử lý yêu cầu của bạn...";
            // 
            // ptb_attachments
            // 
            this.ptb_attachments.ErrorImage = null;
            this.ptb_attachments.Image = ((System.Drawing.Image)(resources.GetObject("ptb_attachments.Image")));
            this.ptb_attachments.InitialImage = ((System.Drawing.Image)(resources.GetObject("ptb_attachments.InitialImage")));
            this.ptb_attachments.Location = new System.Drawing.Point(721, 483);
            this.ptb_attachments.Name = "ptb_attachments";
            this.ptb_attachments.Size = new System.Drawing.Size(29, 30);
            this.ptb_attachments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptb_attachments.TabIndex = 12;
            this.ptb_attachments.TabStop = false;
            this.ptb_attachments.Click += new System.EventHandler(this.ptb_attachments_Click);
            // 
            // lbl_attachments
            // 
            this.lbl_attachments.AutoSize = true;
            this.lbl_attachments.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_attachments.Location = new System.Drawing.Point(12, 391);
            this.lbl_attachments.Name = "lbl_attachments";
            this.lbl_attachments.Size = new System.Drawing.Size(94, 17);
            this.lbl_attachments.TabIndex = 13;
            this.lbl_attachments.Text = "Attachments: ";
            // 
            // lv_attachments
            // 
            this.lv_attachments.HideSelection = false;
            this.lv_attachments.Location = new System.Drawing.Point(115, 391);
            this.lv_attachments.Name = "lv_attachments";
            this.lv_attachments.Size = new System.Drawing.Size(580, 122);
            this.lv_attachments.TabIndex = 14;
            this.lv_attachments.UseCompatibleStateImageBehavior = false;
            // 
            // Bai03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 647);
            this.Controls.Add(this.lv_attachments);
            this.Controls.Add(this.lbl_attachments);
            this.Controls.Add(this.ptb_attachments);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.rtb_body);
            this.Controls.Add(this.tb_subject);
            this.Controls.Add(this.tb_pass);
            this.Controls.Add(this.tb_rcp);
            this.Controls.Add(this.tb_from);
            this.Controls.Add(this.lbl_body);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.lbl_status);
            this.Name = "Bai03";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bai03_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_attachments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.Label lbl_subject;
        private System.Windows.Forms.Label lbl_body;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.TextBox tb_rcp;
        private System.Windows.Forms.TextBox tb_pass;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.RichTextBox rtb_body;
        private System.Windows.Forms.Button bt_send;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.PictureBox ptb_attachments;
        private System.Windows.Forms.Label lbl_attachments;
        private System.Windows.Forms.ListView lv_attachments;
    }
}

