using Quartz;

namespace BinanceApp.Common
{
    public class ScheduleJobListener : IJobListener
    {
        public event TaskExecution Started;
        public event TaskExecution Vetoed;
        public event TaskExecutionComplete Executed;

        public ScheduleJobListener(string name)
        {
            Name = name;
        }

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            Started?.Invoke();
        }

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            Vetoed?.Invoke();
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            Executed?.Invoke(jobException);
        }

        public string Name { get; }
    }

    /*https://memorynotfound.com/quartz-triggerlistener-example/*/
    public class ScheduleTriggerListener : ITriggerListener
    {
        public event ShouldTaskExecution ShouldVeto;

        public ScheduleTriggerListener(string name)
        {
            Name = name;
        }

        public void TriggerFired(ITrigger trigger, IJobExecutionContext context)
        {
        }

        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context)
        {
            if (ShouldVeto == null)
            {
                return false;
            }
            else
            {
                return ShouldVeto();
            }
        }

        public void TriggerMisfired(ITrigger trigger)
        {
        }

        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
        }

        public string Name { get; }
    }
}
