using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinanceApp.GUI.Child
{
    public partial class frmTop30 : XtraForm
    {
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

        private void InitData()
        {
            int count = 1;
            var datasource = from entityRank in StaticValues.lstCryptonRank
                      join entityCoin in StaticValues.lstCoin
                      on entityRank.Coin equals entityCoin.S
                      select new { STT = count++, Coin = entityRank.Coin, CoinName = entityCoin.AN, Count = entityRank.Count, Rate = entityRank.Rate };
            grid.BeginUpdate();
            grid.DataSource = datasource;
            grid.EndUpdate();
        }
    }
}