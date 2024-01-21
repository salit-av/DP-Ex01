using System;
using System.Globalization;

namespace BasicFacebookFeatures
{
    internal class MonthConverter
    {
        internal MonthConverter() { }

        internal int GetMonthNumber(string monthName)
        {
            DateTimeFormatInfo formatInfo = DateTimeFormatInfo.InvariantInfo;
            DateTime date = DateTime.ParseExact(monthName, "MMMM", formatInfo);
            return date.Month;
        }
    }
}