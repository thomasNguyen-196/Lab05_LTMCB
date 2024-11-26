namespace Lab05_LTMCB
{
    partial class Bai01
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
            this.label5 = new System.Windows.Forms.Label();
            this.Subject_lbl = new System.Windows.Forms.Label();
            this.Pwd_lbl = new System.Windows.Forms.Label();
            this.To_lbl = new System.Windows.Forms.Label();
            this.From_lbl = new System.Windows.Forms.Label();
            this.Subject_tb = new System.Windows.Forms.TextBox();
            this.pass_tb = new System.Windows.Forms.TextBox();
            this.to_tb = new System.Windows.Forms.TextBox();
            this.body_rtb = new System.Windows.Forms.RichTextBox();
            this.from_tb = new System.Windows.Forms.TextBox();
            this.snd_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Body: ";
            // 
            // Subject_lbl
            // 
            this.Subject_lbl.AutoSize = true;
            this.Subject_lbl.Location = new System.Drawing.Point(51, 131);
            this.Subject_lbl.Name = "Subject_lbl";
            this.Subject_lbl.Size = new System.Drawing.Size(49, 13);
            this.Subject_lbl.TabIndex = 20;
            this.Subject_lbl.Text = "Subject: ";
            // 
            // Pwd_lbl
            // 
            this.Pwd_lbl.AutoSize = true;
            this.Pwd_lbl.Location = new System.Drawing.Point(541, 15);
            this.Pwd_lbl.Name = "Pwd_lbl";
            this.Pwd_lbl.Size = new System.Drawing.Size(59, 13);
            this.Pwd_lbl.TabIndex = 19;
            this.Pwd_lbl.Text = "Password: ";
            // 
            // To_lbl
            // 
            this.To_lbl.AutoSize = true;
            this.To_lbl.Location = new System.Drawing.Point(151, 51);
            this.To_lbl.Name = "To_lbl";
            this.To_lbl.Size = new System.Drawing.Size(26, 13);
            this.To_lbl.TabIndex = 18;
            this.To_lbl.Text = "To: ";
            // 
            // From_lbl
            // 
            this.From_lbl.AutoSize = true;
            this.From_lbl.Location = new System.Drawing.Point(151, 15);
            this.From_lbl.Name = "From_lbl";
            this.From_lbl.Size = new System.Drawing.Size(36, 13);
            this.From_lbl.TabIndex = 17;
            this.From_lbl.Text = "From: ";
            // 
            // Subject_tb
            // 
            this.Subject_tb.Location = new System.Drawing.Point(112, 128);
            this.Subject_tb.Name = "Subject_tb";
            this.Subject_tb.Size = new System.Drawing.Size(660, 20);
            this.Subject_tb.TabIndex = 16;
            // 
            // pass_tb
            // 
            this.pass_tb.Location = new System.Drawing.Point(603, 12);
            this.pass_tb.Name = "pass_tb";
            this.pass_tb.Size = new System.Drawing.Size(169, 20);
            this.pass_tb.TabIndex = 15;
            // 
            // to_tb
            // 
            this.to_tb.Location = new System.Drawing.Point(213, 48);
            this.to_tb.Name = "to_tb";
            this.to_tb.Size = new System.Drawing.Size(232, 20);
            this.to_tb.TabIndex = 14;
            // 
            // body_rtb
            // 
            this.body_rtb.Location = new System.Drawing.Point(112, 171);
            this.body_rtb.Name = "body_rtb";
            this.body_rtb.Size = new System.Drawing.Size(660, 292);
            this.body_rtb.TabIndex = 13;
            this.body_rtb.Text = "";
            // 
            // from_tb
            // 
            this.from_tb.Location = new System.Drawing.Point(213, 12);
            this.from_tb.Name = "from_tb";
            this.from_tb.Size = new System.Drawing.Size(232, 20);
            this.from_tb.TabIndex = 12;
            // 
            // snd_button
            // 
            this.snd_button.Location = new System.Drawing.Point(12, 12);
            this.snd_button.Name = "snd_button";
            this.snd_button.Size = new System.Drawing.Size(94, 56);
            this.snd_button.TabIndex = 11;
            this.snd_button.Text = "SEND";
            this.snd_button.UseVisualStyleBackColor = true;
            this.snd_button.Click += new System.EventHandler(this.snd_button_Click);
            // 
            // Bai01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 479);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Subject_lbl);
            this.Controls.Add(this.Pwd_lbl);
            this.Controls.Add(this.To_lbl);
            this.Controls.Add(this.From_lbl);
            this.Controls.Add(this.Subject_tb);
            this.Controls.Add(this.pass_tb);
            this.Controls.Add(this.to_tb);
            this.Controls.Add(this.body_rtb);
            this.Controls.Add(this.from_tb);
            this.Controls.Add(this.snd_button);
            this.Name = "Bai01";
            this.Text = "Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Subject_lbl;
        private System.Windows.Forms.Label Pwd_lbl;
        private System.Windows.Forms.Label To_lbl;
        private System.Windows.Forms.Label From_lbl;
        private System.Windows.Forms.TextBox Subject_tb;
        private System.Windows.Forms.TextBox pass_tb;
        private System.Windows.Forms.TextBox to_tb;
        private System.Windows.Forms.RichTextBox body_rtb;
        private System.Windows.Forms.TextBox from_tb;
        private System.Windows.Forms.Button snd_button;
    }
}