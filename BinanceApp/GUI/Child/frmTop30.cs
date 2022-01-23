using BinanceApp.Common;
using BinanceApp.Job;
using BinanceApp.Job.ScheduleJob;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using Quartz;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace BinanceApp.GUI.Child
{
    public partial class frmTop30 : XtraForm
    {
        private ScheduleMember jobCalculate = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<Top30CalculateJob>(), StaticValues.Scron_Top30_Calculate, nameof(Top30CalculateJob));
        private ScheduleMember jobValue = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<Top30ValueScheduleJob>(), StaticValues.Scron_Top30_Value, nameof(Top30ValueScheduleJob));
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
                jobCalculate.Pause();
                jobValue.Pause();
            }
            if (!this.IsHandleCreated)
                return;
            this.Invoke((MethodInvoker)delegate
            {
                grid.BeginUpdate();
                grid.DataSource = StaticValues.lstCryptonRank;
                grid.EndUpdate();
            });
        }

        private void frmTop30_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                jobCalculate.Pause();
                jobValue.Pause();
            }
            else
            {
                if (!jobCalculate.IsStarted())
                {
                    jobCalculate.Start();
                }
                else
                {
                    jobCalculate.Resume();
                }
                
                if (!jobValue.IsStarted())
                {
                    jobValue.Start();
                }
                else
                {
                    jobValue.Resume();
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