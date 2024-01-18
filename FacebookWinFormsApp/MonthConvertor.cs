using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public class MonthConverter
    {
        public static int GetMonthNumber(string monthName)
        {
            DateTimeFormatInfo formatInfo = DateTimeFormatInfo.InvariantInfo;
            DateTime date = DateTime.ParseExact(monthName, "MMMM", formatInfo);
            return date.Month;
        }
    }
}
