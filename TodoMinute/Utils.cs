using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoMinute
{
    public static class Utils
    {
        #region Globalization
        public static string DayOfWeekToString(DayOfWeek day)
        {
            var culture = new System.Globalization.CultureInfo("fr-FR");
            return culture.DateTimeFormat.GetDayName(day);
        }
        #endregion
    }
}
