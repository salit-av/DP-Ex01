﻿using System;

namespace BasicFacebookFeatures
{
    internal class BirthdayFeature
    {
        private readonly int r_Day;
        private readonly int r_Month;

        internal BirthdayFeature(string i_Birthday)
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
            try
            {
                DateTime nextBirthday = new DateTime(DateTime.Now.Year, r_Month, r_Day);
                if (nextBirthday < DateTime.Now)
                {
                    nextBirthday = nextBirthday.AddYears(1);
                }

                return nextBirthday - DateTime.Now;
            }
            catch (ArgumentOutOfRangeException)
            {
                if (r_Month == 2 && r_Day == 29)
                {
                    DateTime nextBirthday = new DateTime(DateTime.Now.Year, r_Month, 28).AddYears(1);
                    return nextBirthday - DateTime.Now;
                }
                else
                {
                    throw;
                }
            }
        }

        internal int GetBirthdayMonth()
        {
            return r_Month;
        }
    }
}
