using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using TodoMinute.Task;

namespace TodoMinute
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("planning.bin"))
            {
                GlobalInfo.Planning = Serializer.Deserialize<Dictionary<DateTime, PlanningDay>>(File.Open("planning.bin", FileMode.Open));
            }
            else if (!GlobalInfo.Planning.ContainsKey(DateTime.Today))
            {
                GlobalInfo.Planning.Add(DateTime.Today, new PlanningDay());
            }

            doneTasksChart.ChartAreas[0].AxisX.Interval = 1;

            RefreshCharts();

            planningPanel1.InitPanel();
        }

        #region Chart
        private int GetTaskInfo(DateTime day, bool done)
        {
            if (GlobalInfo.Planning.ContainsKey(day))
            {
                int amount = 0;
                foreach (var taskDesc in GlobalInfo.Planning[day].Tasks)
                {
                    if (done)
                    {
                        if (taskDesc.Done)
                            amount++;
                    }
                    else
                    {
                        if (!taskDesc.Done)
                            amount++;
                    }
                }
                return amount;
            }
            else
            {
                return 0;
            }
        }

        private string DayOfWeekToString(DayOfWeek day)
        {
            var culture = new System.Globalization.CultureInfo("fr-FR");
            return culture.DateTimeFormat.GetDayName(day);
        }

        private void RefreshCharts()
        {
            doneTasksChart.Series[0].Points.Clear();
            futureTasksChart.Series[0].Points.Clear();

            for (int i = -7; i < 14; i++)
            {
                var day = DateTime.Today.AddDays(i);
                doneTasksChart.Series[0].Points.AddXY(i, GetTaskInfo(day, true));
            }

            for (int i = 0; i < 14; i++)
            {
                var day = DateTime.Today.AddDays(i);
                futureTasksChart.Series[0].Points.AddXY(DayOfWeekToString(day.DayOfWeek), GetTaskInfo(day, false));
            }      
        }
        #endregion

        private void AddTaskHIB_Click(object sender, EventArgs e)
        {
            TaskDescription tDesc;

            using (var form = new CreateTaskForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    tDesc = new TaskDescription(form.Title, form.Description);
                }
                else
                {
                    return;
                }
            }

            planningPanel1.AddTask(tDesc);       
        }

        private void TodoDaySlider1_OnDayChanged(object sender)
        {
            if (!GlobalInfo.Planning.ContainsKey(todoDaySlider1.SelectedDate))
            {
                GlobalInfo.Planning.Add(todoDaySlider1.SelectedDate, new PlanningDay());
            }

            planningPanel1.ChangeDay(todoDaySlider1.SelectedDate);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serializer.Serialize(GlobalInfo.Planning, File.Open("planning.bin", FileMode.Create));
        }

        private void mainTC_Selecting(object sender, TabControlCancelEventArgs e)
        {
            RefreshCharts();
        }
    }
}