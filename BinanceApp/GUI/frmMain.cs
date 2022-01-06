using BinanceApp.Analyze;
using BinanceApp.Common;
using BinanceApp.Data;
using BinanceApp.GUI.Child;
using BinanceApp.Model.ENUM;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceApp.GUI
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private WaitFunc _frmWaitForm = new WaitFunc();
        private BackgroundWorker _bkgr;
        //private bool _checkConnection;
        private frmMain()
        {
            InitializeComponent();
            ribbon.Enabled = false;
            StaticValues.IsAccessMain = true;
            _bkgr = new BackgroundWorker();
            _bkgr.DoWork += bkgrConfig_DoWork;
            _bkgr.RunWorkerCompleted += bkgrConfig_RunWorkerCompleted;
            _bkgr.RunWorkerAsync();
        }

        private static frmMain _instance = null;
        public static frmMain Instance()
        {
            _instance = _instance ?? new frmMain();
            return _instance;
        }

//        private void bkgrCheckConnection_DoWork(object sender, DoWorkEventArgs e)
//        {
//            Thread.Sleep(1000);
//            _frmWaitForm.Show("Kiểm tra kết nối");
//            _checkConnection = CommonMethod.CheckForInternetConnection();
//            Thread.Sleep(200);
//            _frmWaitForm.Close();
//            if (!_checkConnection)
//            {
//                MessageBox.Show("Không có kết nối Internet");
//            }
//        }

//        private void bkgrCheckConnection_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
//        {
//            if (!_checkConnection)
//            {
//                this.Close();
//            }
//            else
//            {
//                _bkgr.DoWork -= bkgrCheckConnection_DoWork;
//                _bkgr.RunWorkerCompleted -= bkgrCheckConnection_RunWorkerCompleted;
//#if Flag_Test
//#else
//                _bkgr.DoWork += bkgrConfig_DoWork;
//                _bkgr.RunWorkerCompleted += bkgrConfig_RunWorkerCompleted;
//                _bkgr.RunWorkerAsync();
//#endif

//                ribbon.Enabled = true;
//            }
//        }

        private void bkgrConfig_DoWork(object sender, DoWorkEventArgs e)
        {
            //dtStartConfig = DateTime.Now;
            _frmWaitForm.Show("Thiết lập ban đầu");
            var lstTask = new List<Task>();
            foreach (var item in StaticValues.lstCoinFilter)
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
            _frmWaitForm.Show("Phân tích dữ liệu");
            CalculateMng.CryptonRank();
            Thread.Sleep(200);
            _frmWaitForm.Close();
        }
        private void bkgrAnalyze_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ribbon.Enabled = true;
            //dtEndCalculate = DateTime.Now;
            //MessageBox.Show($"Started Config: {dtStartConfig} - Ended: {dtEndConfig}\n Started Analyze: {dtStartCalculate} - Ended: {dtEndCalculate}; Count: {StaticValues.lstCryptonRank.Count}");
        }

        private void barBtnInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmProfile.Instance().Show();
        }

        private void barBtnTop30_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tabControl.AddTab(frmTop30.Instance());
            });
        }

        private void barBtnListTrade_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tabControl.AddTab(frmTradeList.Instance());
            });
        }

        private void barBtnListFollow_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //var tmp = StaticValues.ScheduleMngObj.GetSchedules().ElementAt(0);
            //if (tmp.IsStarted())
            //{
            //    tmp.Pause();
            //    tmp.Resume();
            //}
            //else
            //{
            //    tmp.Start();
            //}
            this.Invoke((MethodInvoker)delegate
            {
                tabControl.AddTab(frmFollowList.Instance());
            });
        }

        private void barBtnBlackList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tabControl.AddTab(frmBlackList.Instance());
            });
        }

        private void barBtnConfigFx_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tabControl.AddTab(frmConfigFx.Instance());
            });
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

        private void tabControl_CloseButtonClick(object sender, EventArgs e)
        {
            var EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            string name = EArg.Page.Text;//Get the text of the closed tab
            foreach (XtraTabPage page in tabControl.TabPages)//Traverse to get the same text as the closed tab
            {
                if (page.Text == name)
                {
                    tabControl.TabPages.Remove(page);
                    return;
                }
            }
        }
    }
}