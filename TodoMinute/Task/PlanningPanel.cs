using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoMinute.Theme;

namespace TodoMinute.Task
{
    class TodoPanelException : Exception
    {
        public string Content { get; set; }
        public TodoPanelException(string message)
        {
            Content = message;
        }
    }
    class PlanningPanel : Panel
    {
        private DateTime _day;
        private List<TodoTask> _tasks;

        public PlanningPanel()
        {
            DoubleBuffered = true;
        }

        public void InitPanel()
        {
            _tasks = new List<TodoTask>();
            _day = DateTime.Today;
            LoadTasks();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Size = new Size(360, Height);
        }

        public void ChangeDay(DateTime day)
        {
            _day = day;
            LoadTasks();
        }

        private void LoadTasks()
        {
            Controls.Clear();
            _tasks.Clear();

            var nextTaskPos = new Point(0, 0);

            foreach (var desc in GlobalInfo.Planning[_day].Tasks)
            {
                var task = new TodoTask(desc);
                task.Size = new Size(360, 36);
                task.Location = nextTaskPos;

                _tasks.Add(task);
                Controls.Add(task);

                nextTaskPos = new Point(0, task.Bottom);
            }
        }

        public void Save()
        {
            GlobalInfo.Planning[_day].Tasks.Clear();

            foreach (var task in _tasks)
            {
                GlobalInfo.Planning[_day].Tasks.Add(task.TDescription);
            }
        }

        public void AddTask(TaskDescription description)
        {
            GlobalInfo.Planning[_day].Tasks.Add(description);
            LoadTasks();
        }

        public void RemoveTask(TodoTask task)
        {
            _tasks.Remove(task);
            Save();
            LoadTasks();
        }
    }
}