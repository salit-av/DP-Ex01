using FacebookWrapper.ObjectModel;
using System;

namespace BasicFacebookFeatures
{
    public class PostAnalyzer
    {
        private User m_User;

        public PostAnalyzer(User i_User)
        {
            this.m_User = i_User;
        }

        public int CountPostsInPeriod(string i_periodOfTime)
        {
            int counter = 0;
            DateTime now = DateTime.Now;

            foreach (Post post in m_User.Posts)
            {
                DateTime postDate = post.CreatedTime.Value;

                if (isPostInSelectedPeriod(postDate, i_periodOfTime, now))
                {
                    counter++;
                }
            }

            return counter;
        }

        private bool isPostInSelectedPeriod(DateTime postDate, string selectedPeriod, DateTime now)
        {
            bool isPostInPeriod = false;

            switch (selectedPeriod)
            {
                case "This Month":
                    isPostInPeriod = postDate.Year == now.Year && postDate.Month == now.Month;
                    break;

                case "Last 3 Months":
                    DateTime threeMonthsAgo = now.AddMonths(-3);
                    isPostInPeriod = postDate > threeMonthsAgo && postDate <= now;
                    break;

                case "Last 12 Months":
                    DateTime twelveMonthsAgo = now.AddMonths(-12);
                    isPostInPeriod = postDate > twelveMonthsAgo && postDate <= now;
                    break;

                case "Last Five Years":
                    DateTime fiveYearsAgo = now.AddYears(-5);
                    isPostInPeriod = postDate > fiveYearsAgo && postDate <= now;
                    break;

                case "Last Ten Years":
                    DateTime tenYearsAgo = now.AddYears(-10);
                    isPostInPeriod = postDate > tenYearsAgo && postDate <= now;
                    break;
            }

            return isPostInPeriod;
        }
    }
}
