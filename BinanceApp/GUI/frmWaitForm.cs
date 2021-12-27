using System;
using DevExpress.XtraWaitForm;

namespace BinanceApp.GUI
{
    public partial class frmWaitForm : WaitForm
    {
        public frmWaitForm(string mes = "")
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;
            if (!string.IsNullOrWhiteSpace(mes))
            {
                this.progressPanel1.Caption = mes;
            }
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}