namespace BinanceApp.Usr
{
    partial class userSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkState = new DevExpress.XtraEditors.ToggleSwitch();
            this.cmbOptionFirst = new System.Windows.Forms.ComboBox();
            this.cmbResultFirst = new System.Windows.Forms.ComboBox();
            this.nmResultFirst = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbResultLast = new System.Windows.Forms.ComboBox();
            this.cmbOptionLast = new System.Windows.Forms.ComboBox();
            this.nmResultLast = new System.Windows.Forms.NumericUpDown();
            this.nmPoint = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.LinkLabel();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.nmResult = new System.Windows.Forms.NumericUpDown();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chkState.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResultFirst)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResultLast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResult)).BeginInit();
            this.SuspendLayout();
            // 
            // chkState
            // 
            this.chkState.Location = new System.Drawing.Point(5, 12);
            this.chkState.Name = "chkState";
            this.chkState.Properties.OffText = "Tắt";
            this.chkState.Properties.OnText = "Sử dụng";
            this.chkState.Size = new System.Drawing.Size(111, 18);
            this.chkState.TabIndex = 1;
            // 
            // cmbOptionFirst
            // 
            this.cmbOptionFirst.BackColor = System.Drawing.Color.White;
            this.cmbOptionFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptionFirst.FormattingEnabled = true;
            this.cmbOptionFirst.Location = new System.Drawing.Point(122, 11);
            this.cmbOptionFirst.Name = "cmbOptionFirst";
            this.cmbOptionFirst.Size = new System.Drawing.Size(121, 21);
            this.cmbOptionFirst.TabIndex = 2;
            this.cmbOptionFirst.SelectedIndexChanged += new System.EventHandler(this.cmbOptionFirst_SelectedIndexChanged);
            // 
            // cmbResultFirst
            // 
            this.cmbResultFirst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultFirst.FormattingEnabled = true;
            this.cmbResultFirst.Location = new System.Drawing.Point(245, 11);
            this.cmbResultFirst.Name = "cmbResultFirst";
            this.cmbResultFirst.Size = new System.Drawing.Size(62, 21);
            this.cmbResultFirst.TabIndex = 3;
            this.cmbResultFirst.Visible = false;
            // 
            // nmResultFirst
            // 
            this.nmResultFirst.Location = new System.Drawing.Point(245, 12);
            this.nmResultFirst.Name = "nmResultFirst";
            this.nmResultFirst.Size = new System.Drawing.Size(62, 20);
            this.nmResultFirst.TabIndex = 4;
            this.nmResultFirst.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(11, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "-";
            // 
            // cmbResultLast
            // 
            this.cmbResultLast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbResultLast.FormattingEnabled = true;
            this.cmbResultLast.Location = new System.Drawing.Point(466, 11);
            this.cmbResultLast.Name = "cmbResultLast";
            this.cmbResultLast.Size = new System.Drawing.Size(62, 21);
            this.cmbResultLast.TabIndex = 7;
            this.cmbResultLast.Visible = false;
            // 
            // cmbOptionLast
            // 
            this.cmbOptionLast.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOptionLast.FormattingEnabled = true;
            this.cmbOptionLast.Location = new System.Drawing.Point(343, 11);
            this.cmbOptionLast.Name = "cmbOptionLast";
            this.cmbOptionLast.Size = new System.Drawing.Size(121, 21);
            this.cmbOptionLast.TabIndex = 5;
            this.cmbOptionLast.SelectedIndexChanged += new System.EventHandler(this.cmbOptionLast_SelectedIndexChanged);
            // 
            // nmResultLast
            // 
            this.nmResultLast.Location = new System.Drawing.Point(466, 12);
            this.nmResultLast.Name = "nmResultLast";
            this.nmResultLast.Size = new System.Drawing.Size(62, 20);
            this.nmResultLast.TabIndex = 6;
            this.nmResultLast.Visible = false;
            // 
            // nmPoint
            // 
            this.nmPoint.Location = new System.Drawing.Point(767, 12);
            this.nmPoint.Name = "nmPoint";
            this.nmPoint.Size = new System.Drawing.Size(62, 20);
            this.nmPoint.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Điểm";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(837, 14);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(33, 13);
            this.lblClose.TabIndex = 12;
            this.lblClose.TabStop = true;
            this.lblClose.Text = "Close";
            this.lblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClose_LinkClicked);
            // 
            // cmbOperator
            // 
            this.cmbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Location = new System.Drawing.Point(538, 11);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(44, 21);
            this.cmbOperator.TabIndex = 8;
            // 
            // nmResult
            // 
            this.nmResult.DecimalPlaces = 2;
            this.nmResult.Location = new System.Drawing.Point(588, 12);
            this.nmResult.Name = "nmResult";
            this.nmResult.Size = new System.Drawing.Size(62, 20);
            this.nmResult.TabIndex = 9;
            // 
            // cmbUnit
            // 
            this.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(654, 11);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(57, 21);
            this.cmbUnit.TabIndex = 10;
            // 
            // userSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbUnit);
            this.Controls.Add(this.nmResult);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmPoint);
            this.Controls.Add(this.cmbOptionLast);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkState);
            this.Controls.Add(this.cmbOptionFirst);
            this.Controls.Add(this.cmbResultFirst);
            this.Controls.Add(this.nmResultFirst);
            this.Controls.Add(this.cmbResultLast);
            this.Controls.Add(this.nmResultLast);
            this.Name = "userSetting";
            this.Size = new System.Drawing.Size(892, 42);
            ((System.ComponentModel.ISupportInitialize)(this.chkState.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResultFirst)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResultLast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.ToggleSwitch chkState;
        public System.Windows.Forms.ComboBox cmbOptionFirst;
        public System.Windows.Forms.ComboBox cmbResultFirst;
        public System.Windows.Forms.NumericUpDown nmResultFirst;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbResultLast;
        public System.Windows.Forms.ComboBox cmbOptionLast;
        public System.Windows.Forms.NumericUpDown nmResultLast;
        public System.Windows.Forms.NumericUpDown nmPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lblClose;
        public System.Windows.Forms.ComboBox cmbOperator;
        public System.Windows.Forms.NumericUpDown nmResult;
        public System.Windows.Forms.ComboBox cmbUnit;
    }
}
