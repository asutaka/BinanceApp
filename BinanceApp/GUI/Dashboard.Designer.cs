namespace BinanceApp.GUI
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEmail = new System.Windows.Forms.TabPage();
            this.checkBoxEmailSched = new System.Windows.Forms.CheckBox();
            this.richTextEmailSched = new System.Windows.Forms.RichTextBox();
            this.tabHr = new System.Windows.Forms.TabPage();
            this.checkBoxHrSched = new System.Windows.Forms.CheckBox();
            this.richTextHrSched = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabEmail.SuspendLayout();
            this.tabHr.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEmail);
            this.tabControl1.Controls.Add(this.tabHr);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(836, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEmail
            // 
            this.tabEmail.Controls.Add(this.checkBoxEmailSched);
            this.tabEmail.Controls.Add(this.richTextEmailSched);
            this.tabEmail.Location = new System.Drawing.Point(4, 22);
            this.tabEmail.Name = "tabEmail";
            this.tabEmail.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmail.Size = new System.Drawing.Size(828, 419);
            this.tabEmail.TabIndex = 0;
            this.tabEmail.Text = "Email";
            this.tabEmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmailSched
            // 
            this.checkBoxEmailSched.AutoSize = true;
            this.checkBoxEmailSched.Location = new System.Drawing.Point(6, 6);
            this.checkBoxEmailSched.Name = "checkBoxEmailSched";
            this.checkBoxEmailSched.Size = new System.Drawing.Size(48, 17);
            this.checkBoxEmailSched.TabIndex = 1;
            this.checkBoxEmailSched.Text = "Start";
            this.checkBoxEmailSched.UseVisualStyleBackColor = true;
            // 
            // richTextEmailSched
            // 
            this.richTextEmailSched.Location = new System.Drawing.Point(6, 45);
            this.richTextEmailSched.Name = "richTextEmailSched";
            this.richTextEmailSched.Size = new System.Drawing.Size(816, 368);
            this.richTextEmailSched.TabIndex = 0;
            this.richTextEmailSched.Text = "";
            // 
            // tabHr
            // 
            this.tabHr.Controls.Add(this.checkBoxHrSched);
            this.tabHr.Controls.Add(this.richTextHrSched);
            this.tabHr.Location = new System.Drawing.Point(4, 22);
            this.tabHr.Name = "tabHr";
            this.tabHr.Padding = new System.Windows.Forms.Padding(3);
            this.tabHr.Size = new System.Drawing.Size(828, 419);
            this.tabHr.TabIndex = 1;
            this.tabHr.Text = "Hr";
            this.tabHr.UseVisualStyleBackColor = true;
            // 
            // checkBoxHrSched
            // 
            this.checkBoxHrSched.AutoSize = true;
            this.checkBoxHrSched.Location = new System.Drawing.Point(6, 6);
            this.checkBoxHrSched.Name = "checkBoxHrSched";
            this.checkBoxHrSched.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHrSched.TabIndex = 3;
            this.checkBoxHrSched.Text = "Start";
            this.checkBoxHrSched.UseVisualStyleBackColor = true;
            // 
            // richTextHrSched
            // 
            this.richTextHrSched.Location = new System.Drawing.Point(6, 43);
            this.richTextHrSched.Name = "richTextHrSched";
            this.richTextHrSched.Size = new System.Drawing.Size(816, 370);
            this.richTextHrSched.TabIndex = 2;
            this.richTextHrSched.Text = "";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 469);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabEmail.ResumeLayout(false);
            this.tabEmail.PerformLayout();
            this.tabHr.ResumeLayout(false);
            this.tabHr.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEmail;
        private System.Windows.Forms.TabPage tabHr;
        private System.Windows.Forms.RichTextBox richTextEmailSched;
        private System.Windows.Forms.CheckBox checkBoxEmailSched;
        private System.Windows.Forms.CheckBox checkBoxHrSched;
        private System.Windows.Forms.RichTextBox richTextHrSched;
    }
}