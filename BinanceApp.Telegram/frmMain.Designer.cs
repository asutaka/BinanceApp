
namespace BinanceApp.Telegram
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerifyCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnRequestCode = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkService = new System.Windows.Forms.CheckBox();
            this.lblStatusInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApiHash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtApiId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatusCode = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // btnVerifyCode
            // 
            this.btnVerifyCode.Location = new System.Drawing.Point(305, 56);
            this.btnVerifyCode.Name = "btnVerifyCode";
            this.btnVerifyCode.Size = new System.Drawing.Size(83, 37);
            this.btnVerifyCode.TabIndex = 4;
            this.btnVerifyCode.Text = "Verify Code";
            this.btnVerifyCode.UseVisualStyleBackColor = true;
            this.btnVerifyCode.Click += new System.EventHandler(this.btnVerifyCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(116, 28);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(272, 20);
            this.txtCode.TabIndex = 6;
            // 
            // btnRequestCode
            // 
            this.btnRequestCode.Location = new System.Drawing.Point(305, 140);
            this.btnRequestCode.Name = "btnRequestCode";
            this.btnRequestCode.Size = new System.Drawing.Size(83, 33);
            this.btnRequestCode.TabIndex = 7;
            this.btnRequestCode.Text = "Request Code";
            this.btnRequestCode.UseVisualStyleBackColor = true;
            this.btnRequestCode.Click += new System.EventHandler(this.btnRequestCode_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkService);
            this.groupBox1.Controls.Add(this.lblStatusInfo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnRequestCode);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtApiHash);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtApiId);
            this.groupBox1.Location = new System.Drawing.Point(1, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 176);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // chkService
            // 
            this.chkService.AutoSize = true;
            this.chkService.Location = new System.Drawing.Point(116, 110);
            this.chkService.Name = "chkService";
            this.chkService.Size = new System.Drawing.Size(62, 17);
            this.chkService.TabIndex = 21;
            this.chkService.Text = "Service";
            this.chkService.UseVisualStyleBackColor = true;
            // 
            // lblStatusInfo
            // 
            this.lblStatusInfo.AutoSize = true;
            this.lblStatusInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStatusInfo.Location = new System.Drawing.Point(113, 150);
            this.lblStatusInfo.Name = "lblStatusInfo";
            this.lblStatusInfo.Size = new System.Drawing.Size(33, 13);
            this.lblStatusInfo.TabIndex = 20;
            this.lblStatusInfo.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "SĐT";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(116, 27);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(272, 20);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.Text = "+84582208920";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "API Hash";
            // 
            // txtApiHash
            // 
            this.txtApiHash.Location = new System.Drawing.Point(116, 82);
            this.txtApiHash.Name = "txtApiHash";
            this.txtApiHash.Size = new System.Drawing.Size(272, 20);
            this.txtApiHash.TabIndex = 15;
            this.txtApiHash.Text = "a894a079cfeadf0bd0646f53bf2587c6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "API ID";
            // 
            // txtApiId
            // 
            this.txtApiId.Location = new System.Drawing.Point(116, 54);
            this.txtApiId.Name = "txtApiId";
            this.txtApiId.Size = new System.Drawing.Size(272, 20);
            this.txtApiId.TabIndex = 13;
            this.txtApiId.Text = "5128731";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lblStatusCode);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtCode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnVerifyCode);
            this.groupBox2.Location = new System.Drawing.Point(1, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 103);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Code";
            // 
            // lblStatusCode
            // 
            this.lblStatusCode.AutoSize = true;
            this.lblStatusCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblStatusCode.Location = new System.Drawing.Point(113, 68);
            this.lblStatusCode.Name = "lblStatusCode";
            this.lblStatusCode.Size = new System.Drawing.Size(33, 13);
            this.lblStatusCode.TabIndex = 22;
            this.lblStatusCode.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(415, 285);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gen Session";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerifyCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnRequestCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApiHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtApiId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblStatusInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatusCode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkService;
    }
}

