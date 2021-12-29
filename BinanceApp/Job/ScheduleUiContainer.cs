using BinanceApp.Common;
using BinanceApp.Common.ScheduleJob.ScheduleJobLib;
using BinanceApp.UserControl;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BinanceApp.Job
{
    public class ScheduleUiContainer
    {
        private const uint MaxLine = 720;
        private const string DateTimeDisplayFormat = "dd-MMM-yyyy hh:mm:ss tt";
        private readonly Form Form;
        private readonly RichTextBox RichTextBox;
        private readonly CheckBox CheckBoxStartPause;
        private readonly ISchedule Schedule;

        public ScheduleUiContainer(Form form, userMonitorSchedule user, ISchedule schedule)
        {
            Form = form;
            RichTextBox = user.GetRichTextBox();
            CheckBoxStartPause = user.GetCheckBox();
            Schedule = schedule;
        }

        internal void Initialize()
        {
            Form.Invoke((MethodInvoker)delegate
            {
                CheckBoxStartPause.Appearance = Appearance.Button;
                CheckBoxStartPause.TextAlign = ContentAlignment.MiddleCenter;
                CheckBoxStartPause.MinimumSize = new Size(75, 25); //To prevent shrinkage!
                CheckBoxStartPause.Text = "Start";
                CheckBoxStartPause.Click += CheckBoxStartPause_Click;
            });
        }

        private void PrintNextEstimatedStartTime(DateTime? dateTime)
        {
            string msg = "Estimated: ";
            if (dateTime != null)
            {
                msg += ((DateTime)dateTime).ToString(DateTimeDisplayFormat);
            }

            Form.Invoke((MethodInvoker)delegate
            {
                RichTextBox.AddLine(msg, MaxLine);
                RichTextBox.ScrollToCaret();
            });
        }

        private void BeforeStart()
        {
            Form.Invoke((MethodInvoker)delegate
            {
                RichTextBox.AppendText("\t\t" + "Started: " + DateTime.Now.ToString(DateTimeDisplayFormat));
                RichTextBox.ScrollToCaret();
            });
        }

        private void AfterEnd(Exception exception)
        {
            Form.Invoke((MethodInvoker)delegate
            {
                RichTextBox.AppendText("\t\t" + "Ended: " + DateTime.Now.ToString(DateTimeDisplayFormat));
                RichTextBox.ScrollToCaret();
            });
            string status = String.Empty;
            if (exception != null)
            {
                status = "Error";
                NLogLogger.PublishException(exception, exception.Message);
            }
            else
            {
                status = "Success";
            }
            Form.Invoke((MethodInvoker)delegate
            {
                RichTextBox.AppendText("\t\t" + "Result: " + status);
                RichTextBox.ScrollToCaret();
            });

            if (Schedule.IsPaused())
            {
                Form.Invoke((MethodInvoker)delegate
                {
                    RichTextBox.AddLine("Paused", MaxLine);
                    RichTextBox.ScrollToCaret();
                });
            }
            else
            {
                PrintNextEstimatedStartTime(Schedule.NextEstimatedFireTime());
            }
        }


        /*------------------------------------------------------------------*/
        private void StartSchedule()
        {
            if (!Schedule.IsStarted())
            {
                Schedule.TaskStarted += BeforeStart;
                Schedule.TaskExecuted += AfterEnd;
                Schedule.Start();
            }
            else
            {
                Schedule.Resume();
            }
            PrintNextEstimatedStartTime(Schedule.NextEstimatedFireTime());
        }

        private void PauseSchedule()
        {
            Schedule.Pause();
            if (Schedule.IsTaskRunning())
            {
                MessageBox.Show("Task still running, will be paused after task ends.");
                return;
            }

            Form.Invoke((MethodInvoker)delegate
            {
                RichTextBox.AddLine("Paused", MaxLine);
                RichTextBox.ScrollToCaret();
            });
        }

        private void CheckBoxStartPause_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckBoxStartPause.Checked)
                {
                    StartSchedule();
                    CheckBoxStartPause.Text = "Pause";
                }
                else
                {
                    PauseSchedule();
                    CheckBoxStartPause.Text = "Start";
                }
            }
            catch (Exception ex)
            {
                NLogLogger.PublishException(ex, ex.Message);
                Form.Invoke((MethodInvoker)delegate
                {
                    RichTextBox.AddLine("Error to Run!");
                    RichTextBox.ScrollToCaret();
                });
            }
        }
    }
}
