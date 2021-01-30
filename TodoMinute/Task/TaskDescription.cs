using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMinute.Task
{
    [Serializable]
    public class TaskDescription
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }

        public TaskDescription(string title, string description = "", bool done = false)
        {
            Title = title;
            Description = description;
            Done = done;
        }

        public override string ToString()
        {
            return $"title={Title}; desc={Description}; done={Done}";
        }
    }
}
