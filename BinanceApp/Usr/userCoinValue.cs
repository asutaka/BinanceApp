﻿using BinanceApp.Model.ENTITY;
using System.Windows.Forms;

namespace BinanceApp.Usr
{
    public partial class userCoinValue : UserControl
    {
        public userCoinValue()
        {
            InitializeComponent();
            cmbOption.SelectedIndex = 0; 
        }

        public bool IsAbove()
        {
            return cmbOption.SelectedIndex == 0;
        }

        public decimal GetValue()
        {
            return nmValue.Value;
        }

        public userCoinValue(TradeDetailModel model)
        {
            InitializeComponent();
            cmbOption.SelectedIndex = model.IsAbove ? 0 : 1;
            nmValue.Value = model.Value;
            picOption.Image = model.IsAbove ? Properties.Resources.up_24x24 : Properties.Resources.down_24x24;
        }

        private void cmbOption_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            picOption.Image = cmbOption.SelectedIndex == 0 ? Properties.Resources.up_24x24 : Properties.Resources.down_24x24;
        }

        private void lblClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }
    }
}
