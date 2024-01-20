using System;

namespace BasicFacebookFeatures
{
    internal class Birthday
    {
        private readonly int r_Day;
        private readonly int r_Month;

        internal Birthday(string i_Birthday)
        {
            string[] birthdayDivide = i_Birthday.Split('/');

            if (birthdayDivide.Length == 3)
            {
                r_Month = int.Parse(birthdayDivide[0]);
                r_Day = int.Parse(birthdayDivide[1]);
            }
        }

        internal TimeSpan TimeToBirhtday()
        {
            DateTime nextBirthday = new DateTime(DateTime.Now.Year, r_Month, r_Day);
            if (nextBirthday < DateTime.Now)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            return nextBirthday - DateTime.Now;
        }

        internal int getBirthdayMonth()
        {
            return r_Month;
        }
    }
}
