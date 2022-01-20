using BinanceApp.Common;
using BinanceApp.Job;
using BinanceApp.Job.ScheduleJob;
using BinanceApp.Model.ENTITY;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Quartz;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BinanceApp.GUI.Child
{
    public partial class frmTop30 : XtraForm
    {
        ScheduleMember jobCurrentValue = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<Top30CurrentValueScheduleJob>(), StaticValues.Scron_Top30CurrentValue, nameof(Top30CurrentValueScheduleJob));
        ScheduleMember jobBottomValue = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<Top30BottomValueScheduleJob>(), StaticValues.Scron_Top30BottomValue, nameof(Top30BottomValueScheduleJob));
        private frmTop30()
        {
            InitializeComponent();
            InitData();
        }

        private static frmTop30 _instance = null;
        public static frmTop30 Instance()
        {
            _instance = _instance ?? new frmTop30();
            return _instance;
        }

        public void InitData()
        {
            if (!this.Visible)
            {
                jobCurrentValue.Pause();
                jobBottomValue.Pause();
            }
            if (!this.IsHandleCreated)
                return;
            this.Invoke((MethodInvoker)delegate
            {
                int count = 1;
                var datasource = from entityRank in StaticValues.lstCryptonRank
                                 join entityCoin in StaticValues.lstCoin
                                 on entityRank.Coin equals entityCoin.S
                                 select new Top30Model {   STT = count++, 
                                                Coin = entityRank.Coin, 
                                                CoinName = entityCoin.AN, 
                                                Count = entityRank.Count, 
                                                Rate = entityRank.Rate, 
                                                RefValue = entityRank.OriginValue, 
                                                Value = entityRank.CurrentValue, 
                                                BottomRecent = entityRank.BottomRecent, 
                                                RateValue = Math.Round((-1 + (entityRank.CurrentValue/entityRank.OriginValue)) * 100, 2), 
                                                WaveRecent = entityRank.BottomRecent <= 0 ? 0 : Math.Round((-1 + (entityRank.CurrentValue / entityRank.BottomRecent)) * 100, 2) };
                grid.BeginUpdate();
                grid.DataSource = datasource;
                grid.EndUpdate();
            });
        }

        private void frmTop30_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                jobCurrentValue.Pause();
                jobBottomValue.Pause();
            }
            else
            {
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
    }
}