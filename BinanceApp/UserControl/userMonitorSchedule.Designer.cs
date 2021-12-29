
namespace BinanceApp.UserControl
{
    partial class userMonitorSchedule
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
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.chkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(0, 41);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(592, 343);
            this.txtLog.TabIndex = 0;
            this.txtLog.Text = "";
            // 
            // chkBox
            // 
            this.chkBox.AutoSize = true;
            this.chkBox.Location = new System.Drawing.Point(6, 13);
            this.chkBox.Name = "chkBox";
            this.chkBox.Size = new System.Drawing.Size(50, 17);
            this.chkBox.TabIndex = 1;
            this.chkBox.Text = "Start";
            this.chkBox.UseVisualStyleBackColor = true;
            // 
            // userMonitorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkBox);
            this.Controls.Add(this.txtLog);
            this.Name = "userMonitorSchedule";
            this.Size = new System.Drawing.Size(592, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.CheckBox chkBox;
    }
}
