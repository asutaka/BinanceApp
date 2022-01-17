using BinanceApp.Common;
using BinanceApp.Job;
using BinanceApp.Job.ScheduleJob;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using Quartz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace BinanceApp.GUI.Child
{
    public partial class frmTop30 : XtraForm
    {
        ScheduleMember jobCurrentValue = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<Top30CurrentValueScheduleJob>(), StaticValues.Scron_Top30CurrentValue, nameof(Top30CurrentValueScheduleJob));
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
            }
            if (!this.IsHandleCreated)
                return;
            this.Invoke((MethodInvoker)delegate
            {
                int count = 1;
                var datasource = from entityRank in StaticValues.lstCryptonRank
                                 join entityCoin in StaticValues.lstCoin
                                 on entityRank.Coin equals entityCoin.S
                                 select new { STT = count++, Coin = entityRank.Coin, CoinName = entityCoin.AN, Count = entityRank.Count, Rate = entityRank.Rate, RefValue = entityRank.OriginValue, Value = entityRank.CurrentValue, RateValue = Math.Round((-1 + (entityRank.CurrentValue/entityRank.OriginValue)) * 100, 2) };
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
            }
        }
    }
}