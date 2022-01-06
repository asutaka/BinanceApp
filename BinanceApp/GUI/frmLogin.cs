using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Forms;

namespace BinanceApp.GUI
{
    public partial class frmLogin : XtraForm
    {
        private AuthResponse access;
        private frmLogin()
        {
            InitializeComponent();
            var bkgr = new BackgroundWorker();
            bkgr.DoWork += (object sender, DoWorkEventArgs e) =>
            {
                Startup.Instance();
            };
            bkgr.RunWorkerAsync();
        }

        private static frmLogin _instance = null;
        public static frmLogin Instance()
        {
            _instance = _instance ?? new frmLogin();
            return _instance;
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
            catch (Exception ex)
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
                            if(elementx != null)
                            {
                                var url = ((ValuePattern)elementx.GetCurrentPattern(ValuePattern.Pattern)).Current.Value as string;
                                if (url.Contains("accounts.google.com/o/oauth2/approval/v2/approvalnativeap"))
                                {
                                    var arr = url.Split('&');
                                    var approvalCode = WebUtility.HtmlDecode(arr[arr.Length - 1].Replace("approvalCode=", ""));
                                    this.BeginInvoke(new Action(() =>
                                    {
                                        var profile = GetProfile(approvalCode);
                                        if (profile != null)
                                        {
                                            this.Hide();
                                            StaticValues.profile = profile;
                                            frmProfile.Instance().Show();
                                        }
                                    }));
                                }
                            }
                        }
                    }
                    wrkr.Dispose();
                };
                wrkr.RunWorkerAsync();
            }
            catch (Exception ex)
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
                        if(elementx == null)
                        {
                            return false;
                        }
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
            catch (Exception ex)
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
                if (access == null)
                    return null;
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

        private void frmLogin_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            /*kill all running process
            * https://stackoverflow.com/questions/8507978/exiting-a-c-sharp-winforms-application
            */
            Process.GetCurrentProcess().Kill();
            Application.Exit();
            Environment.Exit(0);
        }
    }
}