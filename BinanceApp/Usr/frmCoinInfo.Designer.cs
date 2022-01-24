
namespace BinanceApp.Usr
{
    partial class frmCoinInfo
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCoin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtValue = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.pnlMain = new System.Windows.Forms.FlowLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnOkAndSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddSignal = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtCoin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã giao dịch";
            // 
            // txtCoin
            // 
            this.txtCoin.Location = new System.Drawing.Point(117, 39);
            this.txtCoin.Name = "txtCoin";
            this.txtCoin.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtCoin.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtCoin.Properties.ReadOnly = true;
            this.txtCoin.Size = new System.Drawing.Size(495, 20);
            this.txtCoin.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Tên Coin";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 97);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(53, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Giá hiện tại";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtValue);
            this.groupControl1.Controls.Add(this.txtDescription);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtCoin);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(640, 133);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(117, 94);
            this.txtValue.Name = "txtValue";
            this.txtValue.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtValue.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtValue.Properties.DisplayFormat.FormatString = "#,##0.########";
            this.txtValue.Properties.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(495, 20);
            this.txtValue.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(117, 68);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White;
            this.txtDescription.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.txtDescription.Properties.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(495, 20);
            this.txtDescription.TabIndex = 4;
            // 
            // pnlMain
            // 
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Location = new System.Drawing.Point(2, 175);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(640, 257);
            this.pnlMain.TabIndex = 13;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.btnCancel);
            this.groupControl2.Controls.Add(this.btnOkAndSave);
            this.groupControl2.Location = new System.Drawing.Point(2, 435);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(640, 78);
            this.groupControl2.TabIndex = 26;
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
            // btnAddSignal
            // 
            this.btnAddSignal.Location = new System.Drawing.Point(0, 13);
            this.btnAddSignal.Name = "btnAddSignal";
            this.btnAddSignal.Size = new System.Drawing.Size(75, 23);
            this.btnAddSignal.TabIndex = 3;
            this.btnAddSignal.Text = "Thêm tín hiệu";
            this.btnAddSignal.Click += new System.EventHandler(this.btnAddSignal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddSignal);
            this.groupBox1.Location = new System.Drawing.Point(2, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 43);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // frmCoinInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 515);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "frmCoinInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin Coin";
            ((System.ComponentModel.ISupportInitialize)(this.txtCoin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtCoin;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txtValue;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private System.Windows.Forms.FlowLayoutPanel pnlMain;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnOkAndSave;
        private DevExpress.XtraEditors.SimpleButton btnAddSignal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}