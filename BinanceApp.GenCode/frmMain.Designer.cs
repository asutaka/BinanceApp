
namespace BinanceApp.GenCode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt1year = new System.Windows.Forms.RadioButton();
            this.rbt6month = new System.Windows.Forms.RadioButton();
            this.rbt3month = new System.Windows.Forms.RadioButton();
            this.rbt1month = new System.Windows.Forms.RadioButton();
            this.rbt3day = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt1year);
            this.groupBox1.Controls.Add(this.rbt6month);
            this.groupBox1.Controls.Add(this.rbt3month);
            this.groupBox1.Controls.Add(this.rbt1month);
            this.groupBox1.Controls.Add(this.rbt3day);
            this.groupBox1.Location = new System.Drawing.Point(27, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách gói";
            // 
            // rbt1year
            // 
            this.rbt1year.AutoSize = true;
            this.rbt1year.Location = new System.Drawing.Point(304, 29);
            this.rbt1year.Name = "rbt1year";
            this.rbt1year.Size = new System.Drawing.Size(54, 17);
            this.rbt1year.TabIndex = 4;
            this.rbt1year.Text = "1 năm";
            this.rbt1year.UseVisualStyleBackColor = true;
            // 
            // rbt6month
            // 
            this.rbt6month.AutoSize = true;
            this.rbt6month.Location = new System.Drawing.Point(231, 30);
            this.rbt6month.Name = "rbt6month";
            this.rbt6month.Size = new System.Drawing.Size(61, 17);
            this.rbt6month.TabIndex = 3;
            this.rbt6month.Text = "6 tháng";
            this.rbt6month.UseVisualStyleBackColor = true;
            // 
            // rbt3month
            // 
            this.rbt3month.AutoSize = true;
            this.rbt3month.Location = new System.Drawing.Point(159, 30);
            this.rbt3month.Name = "rbt3month";
            this.rbt3month.Size = new System.Drawing.Size(61, 17);
            this.rbt3month.TabIndex = 2;
            this.rbt3month.Text = "3 tháng";
            this.rbt3month.UseVisualStyleBackColor = true;
            // 
            // rbt1month
            // 
            this.rbt1month.AutoSize = true;
            this.rbt1month.Location = new System.Drawing.Point(86, 30);
            this.rbt1month.Name = "rbt1month";
            this.rbt1month.Size = new System.Drawing.Size(61, 17);
            this.rbt1month.TabIndex = 1;
            this.rbt1month.Text = "1 tháng";
            this.rbt1month.UseVisualStyleBackColor = true;
            // 
            // rbt3day
            // 
            this.rbt3day.AutoSize = true;
            this.rbt3day.Checked = true;
            this.rbt3day.Location = new System.Drawing.Point(21, 30);
            this.rbt3day.Name = "rbt3day";
            this.rbt3day.Size = new System.Drawing.Size(57, 17);
            this.rbt3day.TabIndex = 0;
            this.rbt3day.TabStop = true;
            this.rbt3day.Text = "3 ngày";
            this.rbt3day.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(71, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(329, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(335, 134);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(64, 37);
            this.btnGenerateCode.TabIndex = 4;
            this.btnGenerateCode.Text = "Lấy Code";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(360, 197);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(39, 22);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(71, 198);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(291, 20);
            this.txtCode.TabIndex = 6;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(425, 258);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenCode";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt1year;
        private System.Windows.Forms.RadioButton rbt6month;
        private System.Windows.Forms.RadioButton rbt3month;
        private System.Windows.Forms.RadioButton rbt1month;
        private System.Windows.Forms.RadioButton rbt3day;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtCode;
    }
}

