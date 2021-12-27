using BinanceApp.Common;
using BinanceApp.Model.ENTITY;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace BinanceApp.UserControl
{
    public partial class userLogin : XtraUserControl
    {
        private AuthResponse access;
        public userLogin()
        {
            InitializeComponent();
        }
        private void picGoogleSignIn_Click(object sender, EventArgs e)
        {
            var url = AuthResponse.GetAutenticationURI(ConstantValue.clientId, ConstantValue.redirectURI).ToString();
            Process.Start(url);
            Thread.Sleep(1000);
            DisplayMemoryUsageInTitleAsync();
        }
        private void DisplayMemoryUsageInTitleAsync()
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
                                GetProfile(approvalCode);
                            }));
                        }
                    }
                }
                wrkr.Dispose();
            };
            wrkr.RunWorkerAsync();
        }
        public bool GetAppoveCodeGoogle()
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
        private async Task<ProfileModel> GetProfile(string approveCode)
        {
            access = AuthResponse.Exchange(approveCode, ConstantValue.clientId, ConstantValue.clientSecret, ConstantValue.redirectURI);
            var url = $"https://www.googleapis.com/oauth2/v3/userinfo?access_token={access.Access_token}";
            var client = new HttpClient();
            client.BaseAddress = new Uri(url);
            //HttpContent c = new StringContent(JsonConvert.SerializeObject(new
            //{
            //    phone = model.Phone,
            //    email = string.Empty,
            //    content = $"{DateTime.Now.ToString("HH:MM:ss")}|{model.Code}|{model.UpDown}|{model.Value}",
            //    serviceId = 1,
            //    sendTelegram = 1,
            //    sendFwork = 0
            //}), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync("", null);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var result = await response.Content.ReadAsStringAsync();
                var model = JsonConvert.DeserializeObject<ProfileModel>(result);
                return model;
            }
            return null;
        }
    }
}
