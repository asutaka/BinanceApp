using BinanceApp.Analyze;
using BinanceApp.Common;
using BinanceApp.Job;
using BinanceApp.Job.ScheduleJob;
using BinanceApp.Model.ENTITY;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceApp.GUI.Child
{
    public partial class frmMCDX : XtraForm
    {
        private WaitFunc _frmWaitForm = new WaitFunc();
        private ScheduleMember jobMCDX = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<MCDXJob>(), StaticValues.Scron_MCDX, nameof(MCDXJob));
        private ScheduleMember jobCurrentValue = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<MCDXCurrentValueScheduleJob>(), StaticValues.Scron_MCDXCurrentValue, nameof(MCDXCurrentValueScheduleJob));
        private ScheduleMember jobBottomValue = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<MCDXBottomValueScheduleJob>(), StaticValues.Scron_MCDXBottomValue, nameof(MCDXBottomValueScheduleJob));
        private frmMCDX()
        {
            InitializeComponent();
        }

        private static frmMCDX _instance = null;
        public static frmMCDX Instance()
        {
            _instance = _instance ?? new frmMCDX();
            return _instance;
        }
        private void Init()
        {
            try
            {
                if (StaticValues.IsExecMCDX)
                    return;
                StaticValues.IsExecMCDX = true;
                StaticValues.lstMCDX.Clear();
                var lstTask = new List<Task>();
                foreach (var item in StaticValues.lstCoinFilter)
                {
                    var task = Task.Run(() =>
                    {
                        if (item.S == "TFUELUSDT")
                        {
                            var tmp = 1;
                        }
                        var val = CalculateMng.MCDX(item.S);
                        if (val.Item1)
                        {
                            var current = CommonMethod.GetCurrentValue(item.S);
                            var bottom = CommonMethod.GetBottomValue(item.S);
                            StaticValues.lstMCDX.Add(new MCDXModel
                            {
                                Coin = item.S,
                                Value = val.Item2,
                                OriginValue = current,
                                CurrentValue = current,
                                BottomRecent = bottom
                            });
                        }
                    });
                    lstTask.Add(task);
                }
                Task.WaitAll(lstTask.ToArray());
                StaticValues.lstMCDX = StaticValues.lstMCDX.OrderByDescending(x => x.Value).ToList();
                InitData();
                StaticValues.IsExecMCDX = false;
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"frmMCDX:Init: {ex.Message}");
            }
        }
        public void InitData()
        {
            if (!this.Visible)
            {
                jobMCDX.Pause();
                jobCurrentValue.Pause();
                jobBottomValue.Pause();
            }
            if (!this.IsHandleCreated)
                return;
            this.Invoke((MethodInvoker)delegate
            {
                int count = 1;
                var datasource = from entityMCDX in StaticValues.lstMCDX
                                 join entityCoin in StaticValues.lstCoin
                                 on entityMCDX.Coin equals entityCoin.S
                                 select new {   STT = count++, 
                                                Coin = entityMCDX.Coin, 
                                                CoinName = entityCoin.AN, 
                                                MCDXValue = entityMCDX.Value,
                                                RefValue = entityMCDX.OriginValue, 
                                                Value = entityMCDX.CurrentValue, 
                                                BottomRecent = entityMCDX.BottomRecent, 
                                                RateValue = Math.Round((-1 + (entityMCDX.CurrentValue/ entityMCDX.OriginValue)) * 100, 2), 
                                                WaveRecent = entityMCDX.BottomRecent <= 0 ? 0 : Math.Round((-1 + (entityMCDX.CurrentValue / entityMCDX.BottomRecent)) * 100, 2) };
                grid.BeginUpdate();
                grid.DataSource = datasource;
                grid.EndUpdate();
            });
        }

        private void frmMCDX_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                jobMCDX.Pause();
                jobCurrentValue.Pause();
                jobBottomValue.Pause();
            }
            else
            {
                if (!jobMCDX.IsStarted())
                {
                    jobMCDX.Start();
                }
                else
                {
                    jobMCDX.Resume();
                }
                if (!jobCurrentValue.IsStarted())
                {
                    jobCurrentValue.Start();
                }
                else
                {
                    jobCurrentValue.Resume();
                }
                if (!jobBottomValue.IsStarted())
                {
                    jobBottomValue.Start();
                }
                else
                {
                    jobBottomValue.Resume();
                }
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo info = gridView1.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                var cellValue = gridView1.GetRowCellValue(info.RowHandle, "Coin").ToString();
                ProcessStartInfo sInfo = new ProcessStartInfo($"{ConstantValue.COIN_SINGLE}{cellValue.Replace("USDT", "_USDT")}");
                Process.Start(sInfo);
            }
        }

        private void frmMCDX_Load(object sender1, EventArgs e1)
        {
            try
            {
                _frmWaitForm.Show("Đang xử lý...");
                var wrkr = new BackgroundWorker();
                wrkr.DoWork += (object sender, DoWorkEventArgs e) => {
                    Init();
                    _frmWaitForm.Close();
                    wrkr.Dispose();
                };
                wrkr.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"frmMCDX:frmMCDX_Load: {ex.Message}");
            }
        }
    }
}