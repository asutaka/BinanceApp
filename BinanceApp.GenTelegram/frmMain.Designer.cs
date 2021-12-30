
namespace BinanceApp.GenTelegram
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnRequestCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(71, 34);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(239, 20);
            this.txtPhone.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.Location = new System.Drawing.Point(316, 105);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(83, 37);
            this.btnVerifyCode.TabIndex = 4;
            this.btnVerifyCode.Text = "Verify Code";
            this.btnVerifyCode.UseVisualStyleBackColor = true;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(71, 70);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(328, 20);
            this.txtCode.TabIndex = 6;
            // 
            // btnRequestCode
            // 
            this.btnRequestCode.Location = new System.Drawing.Point(316, 33);
            this.btnRequestCode.Name = "btnRequestCode";
            this.btnRequestCode.Size = new System.Drawing.Size(83, 22);
            this.btnRequestCode.TabIndex = 7;
            this.btnRequestCode.Text = "Request Code";
            this.btnRequestCode.UseVisualStyleBackColor = true;
            this.btnRequestCode.Click += new System.EventHandler(this.btnRequestCode_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(425, 167);
            this.Controls.Add(this.btnRequestCode);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnVerifyCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gen Session";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerifyCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnRequestCode;
    }
}

