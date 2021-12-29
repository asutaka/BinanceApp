using BinanceApp.Common;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace BinanceApp.GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private WaitFunc _frmWaitForm = new WaitFunc();
        private BackgroundWorker _bkgr;
        private bool _checkConnection;
        public frmMain()
        {
            InitializeComponent();
            ribbon.Enabled = false;
            this.MaximizeBox = false;
            this.userLogin1.SetMain(this);
            _bkgr = new BackgroundWorker();
            _bkgr.DoWork += bkgrCheckConnection_DoWork;
            _bkgr.RunWorkerCompleted += bkgrCheckConnection_RunWorkerCompleted;
            _bkgr.RunWorkerAsync();
            StaticValues.frmMonitorObj = frmMonitor.Instance();
        }
        public void ShowProfile()
        {
            var objProfile = new frmProfile();
            objProfile.TopMost = true;
            objProfile.Show();
            userLogin1.Visible = false;
        }
        private void bkgrCheckConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            _frmWaitForm.Show("Kiểm tra kết nối");
            _checkConnection = CommonMethod.CheckForInternetConnection();
            Thread.Sleep(200);
            _frmWaitForm.Close();
            if (!_checkConnection)
            {
                MessageBox.Show("Không có kết nối Internet");
            }
        }
        private void bkgrCheckConnection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!_checkConnection)
            {
                this.Close();
            }
            else
            {
                _bkgr.DoWork -= bkgrCheckConnection_DoWork;
                _bkgr.RunWorkerCompleted -= bkgrCheckConnection_RunWorkerCompleted;
                userLogin1.Visible = true;
            }
        }
    }
}