﻿using BinanceApp.Common;
using BinanceApp.GUI;
using BinanceApp.Model.ENTITY;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace BinanceApp.UserControl
{
    public partial class userLogin : XtraUserControl
    {
        private AuthResponse access;
        private frmMain _frm;
        public userLogin()
        {
            InitializeComponent();
        }
        public void SetMain(frmMain frm)
        {
            _frm = frm;
        }
        private void picGoogleSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                var url = AuthResponse.GetAuthenticationURI(ConstantValue.clientId, ConstantValue.redirectURI).ToString();
                Process.Start(url);
                Thread.Sleep(1000);
                DisplayMemoryUsageInTitleAsync();
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"UserLogin:GoogleSignIn: {ex.Message}");
            }
        }
        private void DisplayMemoryUsageInTitleAsync()
        {
            try
            {
                BackgroundWorker wrkr = new BackgroundWorker();
                wrkr.WorkerReportsProgress = true;

                wrkr.DoWork += (object sender, DoWorkEventArgs e) => {

                    bool result;
                    while (result = GetAppoveCodeGoogle())
                    {
                        wrkr.ReportProgress(0, result);
                        Thread.Sleep(100);
                    }

                    wrkr.Dispose();
                    Process[] procsChrome = Process.GetProcessesByName("chrome");
                    foreach (Process chrome in procsChrome)
                    {
                        if (chrome.MainWindowHandle == IntPtr.Zero)
                            continue;

                        AutomationElement element = AutomationElement.FromHandle(chrome.MainWindowHandle);
                        if (element != null)
                        {
                            Condition conditions = new AndCondition(
                           new PropertyCondition(AutomationElement.ProcessIdProperty, chrome.Id),
                           new PropertyCondition(AutomationElement.IsControlElementProperty, true),
                           new PropertyCondition(AutomationElement.IsContentElementProperty, true),
                           new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));

                            AutomationElement elementx = element.FindFirst(TreeScope.Descendants, conditions);
                            var url = ((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
                            if (url.Contains("accounts.google.com/o/oauth2/approval/v2/approvalnativeap"))
                            {
                                var arr = url.Split('&');
                                var approvalCode = WebUtility.HtmlDecode(arr[arr.Length - 1].Replace("approvalCode=", ""));
                                this.BeginInvoke(new Action(() =>
                                {
                                    var profile = GetProfile(approvalCode);
                                    if(profile != null)
                                    {
                                        StaticValues.profile = profile;
                                        _frm.ShowProfile();
                                    }
                                }));
                            }
                        }
                    }
                    wrkr.Dispose();
                };
                wrkr.RunWorkerAsync();
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"UserLogin:DisplayMemoryUsageInTitleAsync: {ex.Message}");
            }
        }
        public bool GetAppoveCodeGoogle()
        {
            try
            {
                Process[] procsChrome = Process.GetProcessesByName("chrome");
                foreach (Process chrome in procsChrome)
                {
                    if (chrome.MainWindowHandle == IntPtr.Zero)
                        continue;

                    AutomationElement element = AutomationElement.FromHandle(chrome.MainWindowHandle);
                    if (element != null)
                    {
                        Condition conditions = new AndCondition(
                       new PropertyCondition(AutomationElement.ProcessIdProperty, chrome.Id),
                       new PropertyCondition(AutomationElement.IsControlElementProperty, true),
                       new PropertyCondition(AutomationElement.IsContentElementProperty, true),
                       new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.Edit));

                        AutomationElement elementx = element.FindFirst(TreeScope.Descendants, conditions);
                        var url = ((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
                        if (url.Contains("accounts.google.com/o/oauth2/approval/v2/approvalnativeap"))
                        {
                            var arr = url.Split('&');
                            var approvalCode = WebUtility.HtmlDecode(arr[arr.Length - 1].Replace("approvalCode=", ""));
                            return false;
                        }

                    }
                }
                return true;
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"UserLogin:GetAppoveCodeGoogle");
                return false;
            }
        }
        private ProfileModel GetProfile(string approveCode)
        {
            try
            {
                access = AuthResponse.Exchange(approveCode, ConstantValue.clientId, ConstantValue.clientSecret, ConstantValue.redirectURI);
                var url = $"https://www.googleapis.com/oauth2/v3/userinfo?access_token={access.Access_token}";
                var wc = new WebClient();
                wc.Headers.Add(HttpRequestHeader.AcceptCharset, "utf-8");
                wc.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/5.0 (Windows NT 10.0; …) Gecko/20100101 Firefox/55.0");
                wc.Encoding = Encoding.UTF8;
                var jsonProfile = wc.DownloadString(url);
                var resultModel = JsonConvert.DeserializeObject<ProfileModel>(jsonProfile);
                return resultModel;
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, $"UserLogin:GetProfile: {ex.Message}");
            }
            return null;
        }
    }
}
