
namespace BinanceApp.GUI.Child
{
    partial class frmSpecialSetting
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
            this.components = new System.ComponentModel.Container();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbPrioritySpecial = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkStateSpecial = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbPriorityMCDX = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkStateMCDX = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPriorityTop30 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.chkStateTop30 = new DevExpress.XtraEditors.ToggleSwitch();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOkAndSave = new DevExpress.XtraEditors.SimpleButton();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrioritySpecial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStateSpecial.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriorityMCDX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStateMCDX.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriorityTop30.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStateTop30.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 23);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "1. Top 30";
            this.toolTipController1.SetTitle(this.linkLabel1, "Top 30");
            this.toolTipController1.SetToolTip(this.linkLabel1, "1 - 5:     100đ,\r\n6-10:     80đ,\r\n11-20:   50đ,\r\n20-30:   40đ");
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(6, 22);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(69, 13);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "2. Tiềm năng";
            this.toolTipController1.SetTitle(this.linkLabel2, "Tiềm năng");
            this.toolTipController1.SetToolTip(this.linkLabel2, "value = 20: 100đ,\r\n18 <= value < 20: 80đ,\r\n15 <= value < 18: 70đ,\r\n10 <= value < " +
        "15: 50đ");
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(6, 22);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(60, 13);
            this.linkLabel3.TabIndex = 7;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "3. Đặc biệt";
            this.toolTipController1.SetTitle(this.linkLabel3, "Đặc biệt");
            this.toolTipController1.SetToolTip(this.linkLabel3, "100đ");
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.groupBox3);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Location = new System.Drawing.Point(1, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(905, 213);
            this.groupControl1.TabIndex = 18;
            this.groupControl1.Text = "Thiết lập";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cmbPrioritySpecial);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.chkStateSpecial);
            this.groupBox3.Controls.Add(this.linkLabel3);
            this.groupBox3.Location = new System.Drawing.Point(5, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(893, 54);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // cmbPrioritySpecial
            // 
            this.cmbPrioritySpecial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPrioritySpecial.Location = new System.Drawing.Point(626, 19);
            this.cmbPrioritySpecial.Name = "cmbPrioritySpecial";
            this.cmbPrioritySpecial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPrioritySpecial.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPrioritySpecial.Size = new System.Drawing.Size(119, 20);
            this.cmbPrioritySpecial.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(449, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "(Những mẫu hình có tỉ lệ win tốt nhất, luôn đứng ở vị trí cuối cùng trong danh sá" +
    "ch đánh giá)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(566, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Độ ưu tiên";
            // 
            // chkStateSpecial
            // 
            this.chkStateSpecial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStateSpecial.Location = new System.Drawing.Point(776, 17);
            this.chkStateSpecial.Name = "chkStateSpecial";
            this.chkStateSpecial.Properties.OffText = "Tắt";
            this.chkStateSpecial.Properties.OnText = "Sử dụng";
            this.chkStateSpecial.Size = new System.Drawing.Size(111, 24);
            this.chkStateSpecial.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cmbPriorityMCDX);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkStateMCDX);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Location = new System.Drawing.Point(5, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // cmbPriorityMCDX
            // 
            this.cmbPriorityMCDX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPriorityMCDX.Location = new System.Drawing.Point(626, 17);
            this.cmbPriorityMCDX.Name = "cmbPriorityMCDX";
            this.cmbPriorityMCDX.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPriorityMCDX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPriorityMCDX.Size = new System.Drawing.Size(119, 20);
            this.cmbPriorityMCDX.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(566, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Độ ưu tiên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "(Những coin đang có sóng)";
            // 
            // chkStateMCDX
            // 
            this.chkStateMCDX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStateMCDX.Location = new System.Drawing.Point(776, 15);
            this.chkStateMCDX.Name = "chkStateMCDX";
            this.chkStateMCDX.Properties.OffText = "Tắt";
            this.chkStateMCDX.Properties.OnText = "Sử dụng";
            this.chkStateMCDX.Size = new System.Drawing.Size(111, 24);
            this.chkStateMCDX.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbPriorityTop30);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.chkStateTop30);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(5, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 54);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmbPriorityTop30
            // 
            this.cmbPriorityTop30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPriorityTop30.Location = new System.Drawing.Point(626, 20);
            this.cmbPriorityTop30.Name = "cmbPriorityTop30";
            this.cmbPriorityTop30.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPriorityTop30.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPriorityTop30.Size = new System.Drawing.Size(119, 20);
            this.cmbPriorityTop30.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Độ ưu tiên";
            // 
            // chkStateTop30
            // 
            this.chkStateTop30.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStateTop30.Location = new System.Drawing.Point(776, 17);
            this.chkStateTop30.Name = "chkStateTop30";
            this.chkStateTop30.Properties.OffText = "Tắt";
            this.chkStateTop30.Properties.OnText = "Sử dụng";
            this.chkStateTop30.Size = new System.Drawing.Size(111, 24);
            this.chkStateTop30.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(30 coin mạnh nhất thị trường)";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnOkAndSave);
            this.groupControl2.Location = new System.Drawing.Point(1, 218);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(905, 78);
            this.groupControl2.TabIndex = 25;
            this.groupControl2.Text = "Tùy chọn ";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(129, 34);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 32);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOkAndSave
            // 
            this.btnOkAndSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOkAndSave.Location = new System.Drawing.Point(14, 34);
            this.btnOkAndSave.Name = "btnOkAndSave";
            this.btnOkAndSave.Size = new System.Drawing.Size(109, 32);
            this.btnOkAndSave.TabIndex = 16;
            this.btnOkAndSave.Text = "Lưu cấu hình";
            this.btnOkAndSave.Click += new System.EventHandler(this.btnOkAndSave_Click);
            // 
            // frmSpecialSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 297);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmSpecialSetting";
            this.Text = "Thiết lập đặc biệt";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPrioritySpecial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStateSpecial.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriorityMCDX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStateMCDX.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPriorityTop30.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkStateTop30.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.ToggleSwitch chkStateSpecial;
        private System.Windows.Forms.GroupBox groupBox2;
        public DevExpress.XtraEditors.ToggleSwitch chkStateMCDX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOkAndSave;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPrioritySpecial;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPriorityMCDX;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPriorityTop30;
        private System.Windows.Forms.Label label7;
        public DevExpress.XtraEditors.ToggleSwitch chkStateTop30;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}