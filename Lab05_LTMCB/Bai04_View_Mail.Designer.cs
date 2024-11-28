namespace Lab05_LTMCB
{
    partial class Bai04_View_Mail
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
            this.txt_Mail_Content = new System.Windows.Forms.WebBrowser();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.lb_To = new System.Windows.Forms.Label();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.lb_From = new System.Windows.Forms.Label();
            this.lbl_subject = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Mail_Content
            // 
            this.txt_Mail_Content.Location = new System.Drawing.Point(19, 158);
            this.txt_Mail_Content.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Mail_Content.MinimumSize = new System.Drawing.Size(13, 13);
            this.txt_Mail_Content.Name = "txt_Mail_Content";
            this.txt_Mail_Content.Size = new System.Drawing.Size(760, 265);
            this.txt_Mail_Content.TabIndex = 11;
            // 
            // txt_Subject
            // 
            this.txt_Subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Subject.Location = new System.Drawing.Point(102, 118);
            this.txt_Subject.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.ReadOnly = true;
            this.txt_Subject.Size = new System.Drawing.Size(678, 24);
            this.txt_Subject.TabIndex = 10;
            // 
            // txt_To
            // 
            this.txt_To.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_To.Location = new System.Drawing.Point(102, 69);
            this.txt_To.Margin = new System.Windows.Forms.Padding(2);
            this.txt_To.Name = "txt_To";
            this.txt_To.ReadOnly = true;
            this.txt_To.Size = new System.Drawing.Size(679, 24);
            this.txt_To.TabIndex = 9;
            // 
            // lb_To
            // 
            this.lb_To.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_To.Location = new System.Drawing.Point(19, 71);
            this.lb_To.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_To.Name = "lb_To";
            this.lb_To.Size = new System.Drawing.Size(72, 23);
            this.lb_To.TabIndex = 8;
            this.lb_To.Text = "To:";
            // 
            // txt_From
            // 
            this.txt_From.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_From.Location = new System.Drawing.Point(102, 28);
            this.txt_From.Margin = new System.Windows.Forms.Padding(2);
            this.txt_From.Name = "txt_From";
            this.txt_From.ReadOnly = true;
            this.txt_From.Size = new System.Drawing.Size(679, 24);
            this.txt_From.TabIndex = 7;
            // 
            // lb_From
            // 
            this.lb_From.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_From.Location = new System.Drawing.Point(19, 29);
            this.lb_From.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_From.Name = "lb_From";
            this.lb_From.Size = new System.Drawing.Size(72, 23);
            this.lb_From.TabIndex = 6;
            this.lb_From.Text = "From:";
            // 
            // lbl_subject
            // 
            this.lbl_subject.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subject.Location = new System.Drawing.Point(19, 118);
            this.lbl_subject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_subject.Name = "lbl_subject";
            this.lbl_subject.Size = new System.Drawing.Size(72, 23);
            this.lbl_subject.TabIndex = 12;
            this.lbl_subject.Text = "Subject:";
            // 
            // Bai04_View_Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_subject);
            this.Controls.Add(this.txt_Mail_Content);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.lb_To);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.lb_From);
            this.Name = "Bai04_View_Mail";
            this.Text = "Bai04_View_Mail";
            this.Load += new System.EventHandler(this.Bai04_View_Mail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser txt_Mail_Content;
        private System.Windows.Forms.TextBox txt_Subject;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.Label lb_To;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.Label lb_From;
        private System.Windows.Forms.Label lbl_subject;
    }
}