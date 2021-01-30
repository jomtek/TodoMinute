using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoMinute.Task;

namespace TodoMinute
{
    public static class GlobalInfo
    {
        public static Dictionary<DateTime, PlanningDay> Planning { get; set; }
            = new Dictionary<DateTime, PlanningDay>();
    }
}
