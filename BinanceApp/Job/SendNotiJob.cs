using BinanceApp.Common;
using BinanceApp.Telegram;
using Quartz;
using System;

namespace BinanceApp.Job
{
    [DisallowConcurrentExecution]
    public class SendNotiJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(StaticValues.profile.Phone))
                    return;
                if(StaticValues.lNotify.Count > 0)
                {
                    var val = StaticValues.lNotify.Dequeue();
                    if (string.IsNullOrWhiteSpace(val))
                        return;
                    var result = TeleClient.SendMessage(StaticValues.profile.Phone, val);
                }
            }
            catch(Exception ex)
            {
                NLogLogger.PublishException(ex, $"SendNotiJob:Execute: {ex.Message}");
            }
        }
    }
}

