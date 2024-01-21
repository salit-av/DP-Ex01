using System;

namespace BasicFacebookFeatures
{
    internal class BirthdayFeature
    {
        private readonly int r_Day;
        private readonly int r_Month;
        private readonly int r_Year;

        internal BirthdayFeature(string i_Birthday)
        {
            string[] birthdayDivide = i_Birthday.Split('/');

            if (birthdayDivide.Length == 3)
            {
                r_Month = int.Parse(birthdayDivide[0]);
                r_Day = int.Parse(birthdayDivide[1]);
                r_Year = int.Parse(birthdayDivide[2]);
            }
        }

        internal TimeSpan TimeToBirhtday() 
        {
            DateTime nextBirthday;

            if (r_Month == 2 && r_Day == 29) 
            {
                nextBirthday = new DateTime(DateTime.Now.Year, r_Month, 28).AddYears(1);
            } 
            else
            {
                nextBirthday = new DateTime(DateTime.Now.Year, r_Month, r_Day);

                if (nextBirthday < DateTime.Now) 
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }
            }

            return nextBirthday - DateTime.Now;
        }

        internal int GetBirthdayMonth()
        {
            return r_Month;
        }
    }
}