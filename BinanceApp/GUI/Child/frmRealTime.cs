using System;
using DevExpress.XtraEditors;
using System.Linq;
using System.Windows.Forms;
using BinanceApp.Model.ENTITY;
using BinanceApp.Common;
using System.ComponentModel;
using System.Threading;
using Quartz;
using BinanceApp.Job.ScheduleJob;
using BinanceApp.Job;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Diagnostics;

namespace BinanceApp.GUI.Child
{
    public partial class frmRealTime : XtraForm
    {
        private WaitFunc _frmWaitForm = new WaitFunc();
        private BackgroundWorker _bkgr;
        private const int MAXIMUM = 30;
        private const string _fileName = "realtimelist.json";
        private int count = 1;

        #region Job
        private ScheduleMember job = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<RealtimeValueScheduleJob>(), StaticValues.Scron_Top30_Calculate, nameof(RealtimeValueScheduleJob));
        #endregion
        #region Contructor
        private frmRealTime()
        {
            InitializeComponent();
            this.Enabled = false;
            _bkgr = new BackgroundWorker();
            _bkgr.DoWork += bkgrInitData_DoWork;
            _bkgr.RunWorkerCompleted += bkgrInitData_RunWorkerCompleted;
            _bkgr.RunWorkerAsync();
        }
        private static frmRealTime _instance = null;
        public static frmRealTime Instance()
        {
            _instance = _instance ?? new frmRealTime();
            return _instance;
        }
        #endregion
        #region Function
        public void InitData()
        {
            if (!this.Visible)
            {
                job.Pause();
            }
            if (!this.IsHandleCreated)
                return;
            this.Invoke((MethodInvoker)delegate
            {
                grid.BeginUpdate();
                grid.DataSource = StaticValues.lstRealTimeShow;
                grid.EndUpdate();
            });
        }
        private void AddNewRow(string coin, string coinName)
        {
            StaticValues.lstRealTimeShow.Add(new Top30Model { 
                STT = count++,
                Coin = coin,
                CoinName = coinName,
                Count = 0,
                Rate = 0,
                RefValue = 0,
                Value = 0,
                BottomRecent = 0,
                RateValue = 0,
                WaveRecent = 0,
                CountTime = 0
            });
        }
        #endregion
        #region Event
        private void bkgrInitData_DoWork(object sender, DoWorkEventArgs e)
        {
            _frmWaitForm.Show("Đang xử lý dữ liệu");
            if (StaticValues.lstRealTime.Count() > MAXIMUM)
                StaticValues.lstRealTime = StaticValues.lstRealTime.Take(MAXIMUM).ToList();

            foreach (var item in StaticValues.lstRealTime)
            {
                AddNewRow(item.S, item.AN);
            }
            Thread.Sleep(200);
            _frmWaitForm.Close();
        }
        private void bkgrInitData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbCoin.Properties.ValueMember = "S";
            cmbCoin.Properties.DisplayMember = "AN";
            cmbCoin.Properties.DataSource = StaticValues.lstCoinFilter;
            this.Enabled = true;
            InitData();
        }
        private void cmbCoin_EditValueChanged(object sender, EventArgs e1)
        {
            if (cmbCoin.EditValue == null
                || string.IsNullOrWhiteSpace(cmbCoin.EditValue.ToString()))
                return;

            if (StaticValues.lstRealTime.Any(x => x.S == cmbCoin.EditValue.ToString()))
            {
                MessageBox.Show($"Coin {cmbCoin.EditValue} đã tồn tại trên danh sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }

            if (StaticValues.lstRealTime.Count() >= MAXIMUM)
            {
                MessageBox.Show($"Số lượng phần tử đã vượt quá chỉ định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }
            var coin = cmbCoin.EditValue.ToString();
            var coinName = cmbCoin.Text;
            StaticValues.lstRealTime.Add(new CryptonDetailDataModel
            {
                S = coin,
                AN = coinName
            });
            StaticValues.lstRealTime.UpdateJson(_fileName);
            AddNewRow(coin, coinName);
            cmbCoin.EditValue = null;
        }
        private void frmRealTime_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
            {
                job.Pause();
            }
            else
            {
                if (!job.IsStarted())
                {
                    job.Start();
                }
                else
                {
                    job.Resume();
                }
            }
        }
        #endregion

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

        private void gridView1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                StaticValues.IsRealTimeDeleted = true;
                int[] rows = gridView1.GetSelectedRows();
                if (rows != null && rows.Length > 0)
                {
                    if (MessageBox.Show("Xóa coin được chọn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        _frmWaitForm.Show("Đang xử lý dữ liệu");
                        grid.Enabled = false;
                        Thread.Sleep(1000);
                        var cellValue = gridView1.GetRowCellValue(rows[0], "Coin").ToString();
                        var entity = StaticValues.lstRealTime.FirstOrDefault(x => x.S == cellValue);
                        if (entity != null)
                        {
                            StaticValues.lstRealTime.Remove(entity);
                        }
                        StaticValues.lstRealTime.UpdateJson(_fileName);
                        var entityShow = StaticValues.lstRealTimeShow.FirstOrDefault(x => x.Coin == cellValue);
                        if (entityShow != null)
                        {
                            StaticValues.lstRealTimeShow.Remove(entityShow);
                        }
                        InitData();
                        StaticValues.IsRealTimeDeleted = false;
                        grid.Enabled = true;
                        _frmWaitForm.Close();
                    }
                   
                }
            }
        }
    }
}