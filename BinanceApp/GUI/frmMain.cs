using BinanceApp.Common;
using System;
using System.ComponentModel;
using System.Linq;
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
            StaticValues.IsAccessMain = true;
            _bkgr = new BackgroundWorker();
            _bkgr.DoWork += bkgrCheckConnection_DoWork;
            _bkgr.RunWorkerCompleted += bkgrCheckConnection_RunWorkerCompleted;
            _bkgr.RunWorkerAsync();
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
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var tmp = StaticValues.ScheduleMngObj.GetSchedules().ElementAt(0);
            if (tmp.IsStarted())
            {
                tmp.Pause();
                tmp.Resume();
            }
            else
            {
                tmp.Start();
            }
        }
    }
}