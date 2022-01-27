using BinanceApp.Analyze;
using BinanceApp.Common;
using BinanceApp.Data;
using BinanceApp.GUI.Child;
using BinanceApp.Job;
using BinanceApp.Job.ScheduleJob;
using BinanceApp.Model.ENUM;
using DevExpress.XtraTab;
using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("McSkin");
            ribbon.Enabled = false;
            StaticValues.IsAccessMain = true;
            _bkgr = new BackgroundWorker();
            _bkgr.DoWork += bkgrConfig_DoWork;
            _bkgr.RunWorkerCompleted += bkgrConfig_RunWorkerCompleted;
            _bkgr.RunWorkerAsync();
            StaticValues.ScheduleMngObj.AddSchedule(new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<TradeListNotifyJob>(), StaticValues.Scron_TradeList_Noti, nameof(TradeListNotifyJob)));
            StaticValues.ScheduleMngObj.AddSchedule(new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<FollowListJob>(), StaticValues.followList.Cron, nameof(FollowListJob)));
        }

        private static frmMain _instance = null;
        public static frmMain Instance()
        {
            _instance = _instance ?? new frmMain();
            return _instance;
        }

        private void bkgrConfig_DoWork(object sender, DoWorkEventArgs e)
        {
            //dtStartConfig = DateTime.Now;
            _frmWaitForm.Show("Thiết lập ban đầu");
            var lstTask = new List<Task>();
            foreach (var item in StaticValues.lstCoinFilter)
            {
                var task = Task.Run(() =>
                {
                    StaticValues.dicDatasource1H.Add(item.S, SeedData.LoadDatasource(item.S, (int)enumInterval.OneHour));
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
        }

        private void bkgrAnalyze_DoWork(object sender, DoWorkEventArgs e)
        {
            //dtStartCalculate = DateTime.Now;
            _frmWaitForm.Show("Phân tích dữ liệu");
            StaticValues.lstCryptonRank = CalculateMng.Top30();
            Thread.Sleep(200);
            _frmWaitForm.Close();
        }
        private void bkgrAnalyze_RunWorkerCompleted(object sender1, RunWorkerCompletedEventArgs e1)
        {
            ribbon.Enabled = true;
            _bkgr.DoWork -= bkgrAnalyze_DoWork;
            _bkgr.RunWorkerCompleted -= bkgrAnalyze_RunWorkerCompleted;
            _bkgr.DoWork += bkgrPrepareRealTime_DoWork;
            _bkgr.RunWorkerCompleted += bkgrPrepareRealTime_RunWorkerCompleted;
            _bkgr.RunWorkerAsync();
        }

        private void bkgrPrepareRealTime_DoWork(object sender1, DoWorkEventArgs e1)
        {
            //15M
            if (StaticValues.advanceModel1.LstInterval.Contains((int)enumTimeZone.ThirteenMinute)
                || StaticValues.advanceModel2.LstInterval.Contains((int)enumTimeZone.ThirteenMinute)
                || StaticValues.advanceModel3.LstInterval.Contains((int)enumTimeZone.ThirteenMinute)
                || StaticValues.advanceModel4.LstInterval.Contains((int)enumTimeZone.ThirteenMinute))
            {
                var wrkr = new BackgroundWorker();
                wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                    var lstTask = new List<Task>();
                    foreach (var item in StaticValues.lstCoinFilter)
                    {
                        var task = Task.Run(() =>
                        {
                            StaticValues.dicDatasource15M.Add(item.S, SeedData.LoadDatasource(item.S, (int)enumInterval.ThirteenMinute));
                        });
                        lstTask.Add(task);
                    }
                    Task.WaitAll(lstTask.ToArray());
                };
                wrkr.RunWorkerAsync();
            }
            //4H
            if (StaticValues.advanceModel1.LstInterval.Contains((int)enumTimeZone.FourHour)
              || StaticValues.advanceModel2.LstInterval.Contains((int)enumTimeZone.FourHour)
              || StaticValues.advanceModel3.LstInterval.Contains((int)enumTimeZone.FourHour)
              || StaticValues.advanceModel4.LstInterval.Contains((int)enumTimeZone.FourHour))
            {
                var wrkr = new BackgroundWorker();
                wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                    var lstTask = new List<Task>();
                    foreach (var item in StaticValues.lstCoinFilter)
                    {
                        var task = Task.Run(() =>
                        {
                            StaticValues.dicDatasource4H.Add(item.S, SeedData.LoadDatasource(item.S, (int)enumInterval.FourHour));
                        });
                        lstTask.Add(task);
                    }
                    Task.WaitAll(lstTask.ToArray());
                };
                wrkr.RunWorkerAsync();
            }
            //1D
            if (StaticValues.advanceModel1.LstInterval.Contains((int)enumTimeZone.OneDay)
              || StaticValues.advanceModel2.LstInterval.Contains((int)enumTimeZone.OneDay)
              || StaticValues.advanceModel3.LstInterval.Contains((int)enumTimeZone.OneDay)
              || StaticValues.advanceModel4.LstInterval.Contains((int)enumTimeZone.OneDay))
            {
                var wrkr = new BackgroundWorker();
                wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                    var lstTask = new List<Task>();
                    foreach (var item in StaticValues.lstCoinFilter)
                    {
                        var task = Task.Run(() =>
                        {
                            StaticValues.dicDatasource1D.Add(item.S, SeedData.LoadDatasource(item.S, (int)enumInterval.OneDay));
                        });
                        lstTask.Add(task);
                    }
                    Task.WaitAll(lstTask.ToArray());
                };
                wrkr.RunWorkerAsync();
            }
            //1W
            if (StaticValues.advanceModel1.LstInterval.Contains((int)enumTimeZone.OneWeek)
              || StaticValues.advanceModel2.LstInterval.Contains((int)enumTimeZone.OneWeek)
              || StaticValues.advanceModel3.LstInterval.Contains((int)enumTimeZone.OneWeek)
              || StaticValues.advanceModel4.LstInterval.Contains((int)enumTimeZone.OneWeek))
            {
                var wrkr = new BackgroundWorker();
                wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                    var lstTask = new List<Task>();
                    foreach (var item in StaticValues.lstCoinFilter)
                    {
                        var task = Task.Run(() =>
                        {
                            StaticValues.dicDatasource1W.Add(item.S, SeedData.LoadDatasource(item.S, (int)enumInterval.OneWeek));
                        });
                        lstTask.Add(task);
                    }
                    Task.WaitAll(lstTask.ToArray());
                };
                wrkr.RunWorkerAsync();
            }
            //1Month
            if (StaticValues.advanceModel1.LstInterval.Contains((int)enumTimeZone.OneMonth)
              || StaticValues.advanceModel2.LstInterval.Contains((int)enumTimeZone.OneMonth)
              || StaticValues.advanceModel3.LstInterval.Contains((int)enumTimeZone.OneMonth)
              || StaticValues.advanceModel4.LstInterval.Contains((int)enumTimeZone.OneMonth))
            {
                var wrkr = new BackgroundWorker();
                wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                    var lstTask = new List<Task>();
                    foreach (var item in StaticValues.lstCoinFilter)
                    {
                        var task = Task.Run(() =>
                        {
                            StaticValues.dicDatasource1Month.Add(item.S, SeedData.LoadDatasource(item.S, (int)enumInterval.OneMonth));
                        });
                        lstTask.Add(task);
                    }
                    Task.WaitAll(lstTask.ToArray());
                };
                wrkr.RunWorkerAsync();
            }
        }

        private void bkgrPrepareRealTime_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tabControl.AddTab(frmTop30.Instance());
            });
            try
            {
                foreach (var process in Process.GetProcessesByName(ConstantValue.serviceName))
                {
                    process.Kill();
                }
                Process.Start($"{Directory.GetCurrentDirectory()}\\service\\{ConstantValue.serviceName}.exe");
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"frmMain: {ex.Message}");
            }
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
            try
            {
                foreach (var process in Process.GetProcessesByName(ConstantValue.serviceName))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"frmMain: {ex.Message}");
            }
            Process.GetCurrentProcess().Kill();
            Application.Exit();
            Environment.Exit(0);
        }

        private void tabControl_CloseButtonClick(object sender, EventArgs e)
        {
            //if (tabControl.TabPages.Count == 1)
            //    return;
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

        private void barBtnRealTime_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tabControl.AddTab(frmRealTime.Instance());
            });
        }

        private void barBtnStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnStart.Enabled = false;
            barBtnStop.Enabled = true;

            StaticValues.ScheduleMngObj.StartAllJob();
        }

        private void barBtnStop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnStart.Enabled = true;
            barBtnStop.Enabled = false;

            StaticValues.ScheduleMngObj.StopAllJob();
        }

        private void barBtnMCDX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tabControl.AddTab(frmMCDX.Instance());
            });
        }

        private void barBtnSupport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnSupport.Enabled = false;
            ConstantValue.strSupport.CreateFile("Support", true);
            Thread.Sleep(1000);
            barBtnSupport.Enabled = true;
        }
    }
}