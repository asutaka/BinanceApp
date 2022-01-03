
namespace BinanceApp.Usr
{
    partial class userCoinValue
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
            this.cmbOption = new System.Windows.Forms.ComboBox();
            this.nmValue = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.picOption = new System.Windows.Forms.PictureBox();
            this.lblClose = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nmValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOption
            // 
            this.cmbOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOption.FormattingEnabled = true;
            this.cmbOption.Items.AddRange(new object[] {
            "Giá tăng lên trên",
            "Giá giảm dưới"});
            this.cmbOption.Location = new System.Drawing.Point(42, 11);
            this.cmbOption.Name = "cmbOption";
            this.cmbOption.Size = new System.Drawing.Size(139, 21);
            this.cmbOption.TabIndex = 6;
            this.cmbOption.SelectedIndexChanged += new System.EventHandler(this.cmbOption_SelectedIndexChanged);
            // 
            // nmValue
            // 
            this.nmValue.DecimalPlaces = 8;
            this.nmValue.Location = new System.Drawing.Point(297, 12);
            this.nmValue.Name = "nmValue";
            this.nmValue.Size = new System.Drawing.Size(95, 20);
            this.nmValue.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(257, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Giá trị";
            // 
            // picOption
            // 
            this.picOption.Image = global::BinanceApp.Properties.Resources.up_24x24;
            this.picOption.Location = new System.Drawing.Point(15, 11);
            this.picOption.Name = "picOption";
            this.picOption.Size = new System.Drawing.Size(21, 21);
            this.picOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOption.TabIndex = 12;
            this.picOption.TabStop = false;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(408, 14);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(33, 13);
            this.lblClose.TabIndex = 17;
            this.lblClose.TabStop = true;
            this.lblClose.Text = "Close";
            this.lblClose.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblClose_LinkClicked);
            // 
            // userCoinValue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.picOption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nmValue);
            this.Controls.Add(this.cmbOption);
            this.Name = "userCoinValue";
            this.Size = new System.Drawing.Size(450, 42);
            ((System.ComponentModel.ISupportInitialize)(this.nmValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cmbOption;
        public System.Windows.Forms.NumericUpDown nmValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picOption;
        private System.Windows.Forms.LinkLabel lblClose;
    }
}
