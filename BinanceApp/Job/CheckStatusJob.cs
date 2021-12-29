using BinanceApp.Common;
using BinanceApp.GUI;
using BinanceApp.Model.ENTITY;
using Newtonsoft.Json;
using Quartz;
using System;
using System.Windows.Forms;

namespace BinanceApp.Job
{
    public class CheckStatusJob : IJob
    {
        private const string _fileName = "user.json";
        public void Execute(IJobExecutionContext context)
        {
            if (StaticValues.IsExecCheckCodeActive)
                return;
            StaticValues.IsExecCheckCodeActive = true;
            var time = CommonMethod.GetTimeAsync().GetAwaiter().GetResult();

            var objUser = new UserModel().LoadJsonFile(_fileName);
            var jsonModel = Security.Decrypt(objUser.Code);
            if (string.IsNullOrWhiteSpace(jsonModel))
            {
                StaticValues.IsCodeActive = false;
            }
            else
            {
                var model = JsonConvert.DeserializeObject<GenCodeModel>(jsonModel);
                if (!StaticValues.profile.Email.Contains(model.Email) || model.Expired <= time)
                {
                    StaticValues.IsCodeActive = false;
                }
                else
                {
                    StaticValues.IsCodeActive = true;
                }
            }

            if (!StaticValues.IsCodeActive)
            {
                StaticValues.IsAccessMain = false;
                try
                {
                    if (StaticValues.ScheduleMngObj != null)
                    {
                        foreach (var item in StaticValues.ScheduleMngObj.GetSchedules())
                        {
                            item.Pause();
                        }
                    }
                }
                catch (Exception ex)
                {
                    NLogLogger.PublishException(ex, $"CheckStatusJob: {ex.Message}");
                }

                //về màn hình đăng nhập
                StaticValues.frmMainObj.BeginInvoke((MethodInvoker)delegate
                {
                    StaticValues.frmMainObj.Hide();
                    new frmLogin().Show();
                });
            }
            StaticValues.IsExecCheckCodeActive = false;
        }
    }
}
