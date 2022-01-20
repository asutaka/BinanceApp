using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.Linq;
using System.Windows.Forms;
using BinanceApp.Model.ENTITY;
using BinanceApp.Common;
using BinanceApp.Analyze;
using System.Data;
using System.ComponentModel;
using System.Threading;

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
        private DataTable _dt = new DataTable();
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
            grid.DataSource = _dt;
            grid.EndUpdate();
        }

        private void InitData()
        {
            if (_lstRealTime.Count() > MAXIMUM)
                _lstRealTime = _lstRealTime.Take(30).ToList();
            _dt.Columns.Add("STT", typeof(int));
            _dt.Columns.Add("Coin", typeof(string));
            _dt.Columns.Add("CoinName", typeof(string));
            _dt.Columns.Add("Count", typeof(int));
            _dt.Columns.Add("Rate", typeof(double));
            _dt.Columns.Add("RefValue", typeof(double));
            _dt.Columns.Add("Value", typeof(double));
            _dt.Columns.Add("BottomRecent", typeof(double));
            _dt.Columns.Add("RateValue", typeof(double));
            _dt.Columns.Add("WaveRecent", typeof(double));
            foreach (var item in _lstRealTime)
            {
                CreateNewRow(item.S, item.AN);
            }
        }

        private void cmbCoin_EditValueChanged(object sender, EventArgs e1)
        {
            if (cmbCoin.EditValue == null 
                || string.IsNullOrWhiteSpace(cmbCoin.EditValue.ToString()))
                return;

            if(_lstRealTime.Any(x => x.S == cmbCoin.EditValue.ToString()))
            {
                MessageBox.Show($"Coin {cmbCoin.EditValue} đã tồn tại trên danh sách", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }

            if(_lstRealTime.Count() >= MAXIMUM)
            {
                MessageBox.Show($"Số lượng phần tử đã vượt quá chỉ định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCoin.EditValue = null;
                return;
            }
            CreatNewRow();
            cmbCoin.EditValue = null;
        }

        private void CreatNewRow()
        {
            _frmWaitForm.Show("Đang xử lý dữ liệu");
            var coin = cmbCoin.EditValue.ToString();
            var coinName = cmbCoin.Text;
            _lstRealTime.Add(new CryptonDetailDataModel
            {
                S = coin,
                AN = coinName
            });
            _lstRealTime.UpdateJson(_fileName);
            CreateNewRow(coin, coinName);
            _frmWaitForm.Close();
        }
        private void CreateNewRow(string coin, string coinName)
        {
            var cryptonRank = CalculateMng.CalculateCryptonRank(coin);
            var currentValue = CommonMethod.GetCurrentValue(coin);
            var bottom = CommonMethod.GetBottomValue(coin);
            var row = _dt.NewRow();
            row["STT"] = count++;
            row["Coin"] = coin;
            row["CoinName"] = coinName;
            row["Count"] = cryptonRank.Count;
            row["Rate"] = cryptonRank.Rate;
            row["RefValue"] = currentValue;
            row["Value"] = currentValue;
            row["BottomRecent"] = bottom;
            row["RateValue"] = 0;
            row["WaveRecent"] = bottom <= 0 ? 0 : Math.Round((-1 + (currentValue / bottom)) * 100, 2);
            _dt.Rows.Add(row);
        }
    }
}