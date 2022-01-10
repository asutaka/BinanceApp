﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace BinanceApp.GenTelegram
{
    public partial class frmMain : Form
    {
        private string _phoneNumber;
        public frmMain()
        {
            InitializeComponent();
        }

        private bool CheckValid()
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Chưa nhập SĐT!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApiId.Text))
            {
                MessageBox.Show("Api Id không hợp lệ!");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtApiHash.Text))
            {
                MessageBox.Show("Api Hash không hợp lệ!");
                return false;
            }
            try
            {
                _phoneNumber = txtPhone.Text;//.PhoneFormat(false);
                if (string.IsNullOrWhiteSpace(_phoneNumber))
                {
                    MessageBox.Show("SĐT không hợp lệ!");
                    return false;
                }
            }
            catch(Exception ex)
            {
                //NLogLogger.PublishException(ex, $"GenTelegram|CheckValid: {ex.Message}");
                MessageBox.Show("SĐT không hợp lệ!");
                return false;
            }
            return true;
        }

        private void btnVerifyCode_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
                return;
            var result = TeleClient.GenerateSession(_phoneNumber, txtApiId.Text.Trim(), txtApiHash.Text.Trim(), txtCode.Text.Trim(), chkService.Checked);
            if (result.GetAwaiter().GetResult())
            {
                lblStatusCode.Text = "Thành công";
                lblStatusCode.ForeColor = Color.Green;
            }
            else
            {
                lblStatusCode.Text = "Thất bại";
                lblStatusCode.ForeColor = Color.Red;
            }
        }

        private void btnRequestCode_Click(object sender, EventArgs e)
        {
            if (!CheckValid())
                return;
            var result = TeleClient.GenerateSession(_phoneNumber, txtApiId.Text.Trim(), txtApiHash.Text.Trim(), txtCode.Text.Trim(), chkService.Checked);
            if (result.GetAwaiter().GetResult())
            {
                lblStatusInfo.Text = "Thành công";
                lblStatusInfo.ForeColor = Color.Green;
            }
            else
            {
                lblStatusInfo.Text = "Thất bại";
                lblStatusInfo.ForeColor = Color.Red;
            }
        }
    }
}
