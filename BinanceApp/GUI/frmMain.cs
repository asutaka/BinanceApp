using BinanceApp.Analyze;
using BinanceApp.Common;
using BinanceApp.Data;
using BinanceApp.Model.ENUM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
                _bkgr.DoWork += bkgrConfig_DoWork;
                _bkgr.RunWorkerCompleted += bkgrConfig_RunWorkerCompleted;
                _bkgr.RunWorkerAsync();
                ribbon.Enabled = true;
            }
        }

        private void bkgrConfig_DoWork(object sender, DoWorkEventArgs e)
        {
            //dtStartConfig = DateTime.Now;
            Thread.Sleep(1000);
            _frmWaitForm.Show("Thiết lập ban đầu");
            //StaticValues.basicModel = 0.LoadBasicJson();
            //StaticValues.advanceModel = 0.LoadAdvanceJson();
            StaticValues.lstCoin = SeedData.GetCryptonList();
            //StaticValues.lstCoinTrace = 0.LoadCoinTraceJson();
            //StaticValues.lstUserTrace = 0.LoadUserTraceJson();
            var lstTask = new List<Task>();
            foreach (var item in StaticValues.lstCoin)
            {
                var task = Task.Run(() =>
                {
                    StaticValues.dicDatasource.Add(item.S, SeedData.LoadDatasource(item.S, enumInterval.OneHour.GetDisplayName()));
                });
                lstTask.Add(task);
            }
            Task.WaitAll(lstTask.ToArray());
            Thread.Sleep(200);
            _frmWaitForm.Close();
        }
        private void bkgrConfig_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _bkgr.DoWork -= bkgrConfig_DoWork;
            _bkgr.RunWorkerCompleted -= bkgrConfig_RunWorkerCompleted;
            _bkgr.DoWork += bkgrAnalyze_DoWork;
            _bkgr.RunWorkerCompleted += bkgrAnalyze_RunWorkerCompleted;
            _bkgr.RunWorkerAsync();
            //dtEndConfig = DateTime.Now;
        }

        private void bkgrAnalyze_DoWork(object sender, DoWorkEventArgs e)
        {
            //dtStartCalculate = DateTime.Now;
            Thread.Sleep(1000);
            _frmWaitForm.Show("Phân tích dữ liệu");
            CalculateMng.CryptonRank();
            Thread.Sleep(200);
            _frmWaitForm.Close();
        }
        private void bkgrAnalyze_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //dtEndCalculate = DateTime.Now;
            //MessageBox.Show($"Started Config: {dtStartConfig} - Ended: {dtEndConfig}\n Started Analyze: {dtStartCalculate} - Ended: {dtEndCalculate}; Count: {StaticValues.lstCryptonRank.Count}");
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

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*kill all running process
            * https://stackoverflow.com/questions/8507978/exiting-a-c-sharp-winforms-application
            */
            Process.GetCurrentProcess().Kill();
            Application.Exit();
            Environment.Exit(0);
        }

        private void barBtnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            new frmProfile().Show();
        }
    }
}