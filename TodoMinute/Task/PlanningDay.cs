using System;
using System.Collections.Generic;

namespace TodoMinute.Task
{
    [Serializable]
    public class PlanningDay
    {
        public List<TaskDescription> Tasks { get; set; }

        public PlanningDay()
        {
            Tasks = new List<TaskDescription>();
        }
    }
}