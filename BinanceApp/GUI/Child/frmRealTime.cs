using System;
using System.Collections.Generic;
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

namespace BinanceApp.GUI.Child
{
    public partial class frmRealTime : XtraForm
    {
        private WaitFunc _frmWaitForm = new WaitFunc();
        private BackgroundWorker _bkgr;
        private const int MAXIMUM = 40;
        private const string _fileName = "realtimelist.json";
        private int count = 1;
        private List<CryptonDetailDataModel> _lstRealTime = StaticValues.lstRealTime;

        #region Job
        private ScheduleMember job = new ScheduleMember(StaticValues.ScheduleMngObj.GetScheduler(), JobBuilder.Create<RealtimeScheduleJob>(), StaticValues.Scron_RealTime, nameof(RealtimeScheduleJob));
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
        private void InitData()
        {
            if (_lstRealTime.Count() > MAXIMUM)
                _lstRealTime = _lstRealTime.Take(30).ToList();

            foreach (var item in _lstRealTime)
            {
                AddNewRow(item.S, item.AN);
            }
        }
        private void AddNewRow(string coin, string coinName)
        {
            var row = StaticValues.dtRealTime.NewRow();
            row["STT"] = count++;
            row["Coin"] = coin;
            row["CoinName"] = coinName;
            row["CountTime"] = 0;
            StaticValues.dtRealTime.Rows.Add(row);
        }
        #endregion
        #region Event
        private void bkgrInitData_DoWork(object sender, DoWorkEventArgs e)
        {
            //dtStartConfig = DateTime.Now;
            _frmWaitForm.Show("Đang xử lý dữ liệu");
            InitData();
            Thread.Sleep(200);
            _frmWaitForm.Close();
        }
        private void bkgrInitData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            cmbCoin.Properties.ValueMember = "S";
            cmbCoin.Properties.DisplayMember = "AN";
            cmbCoin.Properties.DataSource = StaticValues.lstCoinFilter;
            this.Enabled = true;
            grid.BeginUpdate();
            grid.DataSource = StaticValues.dtRealTime;
            grid.EndUpdate();

            if (!this.Visible)
            {
                job.Pause();
            }
        }
        private void cmbCoin_EditValueChanged(object sender, EventArgs e1)
        {
            if (cmbCoin.EditValue == null
                || string.IsNullOrWhiteSpace(cmbCoin.EditValue.ToString()))
                return;

            if (_lstRealTime.Any(x => x.S == cmbCoin.EditValue.ToString()))
            {
                MessageBox.Show($"Coin {cmbCoin.EditValue} đã tồn tại trên danh sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }

            if (_lstRealTime.Count() >= MAXIMUM)
            {
                MessageBox.Show($"Số lượng phần tử đã vượt quá chỉ định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }
            _frmWaitForm.Show("Đang xử lý dữ liệu");
            var coin = cmbCoin.EditValue.ToString();
            var coinName = cmbCoin.Text;
            _lstRealTime.Add(new CryptonDetailDataModel
            {
                S = coin,
                AN = coinName
            });
            _lstRealTime.UpdateJson(_fileName);
            AddNewRow(coin, coinName);
            _frmWaitForm.Close();
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
    }
}