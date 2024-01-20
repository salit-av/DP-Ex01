using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const int k_MaxPostLength = 250;
        private RandomSelector m_RandomSelector;
        private Post m_PostToGuess;
        private User m_FriendToGuess;
        private bool m_IsUserGuessedPostYear = false;
        private bool m_IsUserGuessedFriendBirthday = false;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        FacebookWrapper.LoginResult m_LoginResult;
        User m_User;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                /// App ID
                "749307766594184",
                /// requested permissions:
                "email",
                "public_profile",
                "user_posts",
                "user_birthday"
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                m_User = m_LoginResult.LoggedInUser;
                m_RandomSelector = new RandomSelector(m_User);
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                enableButtonsAfterLogin();
            }
        }

        private void enableButtonsAfterLogin()
        {
            comboBoxNumberOfPostPeriodsOfTime.Enabled = true;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonBirthday.Enabled = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            buttonNumberOfPostInPeriodOfTime.Enabled = false;
            buttonBirthday.Enabled = false;
        }

        private void buttonBirthdayCounter_Click(object sender, EventArgs e)
        {
            Birthday birthday = new Birthday(m_User.Birthday);
            TimeSpan timeSpan = birthday.TimeToBirhtday();

            labelBirthdayCountdown.Visible = true;
            labelBirthdayCountdown.Text = $"Time until next birthday: {timeSpan.Days} days, {timeSpan.Hours} hours, {timeSpan.Minutes} minutes.";
            
            if (!m_IsUserGuessedFriendBirthday)
            {
                showGuessBirthdayMonth();
                m_IsUserGuessedFriendBirthday = true;
            }
        }

        private void showGuessBirthdayMonth()
        {
            m_FriendToGuess = m_RandomSelector.GetRandomFriend();
            labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
            visibleFormObjectsOfGuessFriendBirthdayMonth();
        }

        private void visibleFormObjectsOfGuessFriendBirthdayMonth()
        {
            comboBoxGuessBirthdayMonth.Visible = true;
            buttonGuessBirthdayMonth.Visible = true;
            buttonNewBirthdayGuess.Visible = true;
            labelInDevelopment.Visible = true;
            labelGuessFriendBirthday.Visible = true;
            labelFriendName.Visible = true;
        }


        private void buttonNumberOfPostInPeriodOfTime_Click(object sender, EventArgs e)
        {
            labelPleaseWait.Visible = true;
            labelPleaseWait.Text = "Please wait...";

            labelNumberOfPostsInPeriodOfTime.Visible = true;
            labelNumberOfPostsInPeriodOfTime.Text = $"{getNumberOfPostInRequestedTimePeriod()} posts found";

            labelPleaseWait.Visible = false;

            if (!m_IsUserGuessedPostYear)
            {
                showGuessPostYear();
                m_IsUserGuessedPostYear = true;
            }
        }

        private int getNumberOfPostInRequestedTimePeriod()
        {
            int counter = 0;
            string selectedPeriodOption = comboBoxNumberOfPostPeriodsOfTime.SelectedItem.ToString();
            DateTime now = DateTime.Now;

            foreach (Post post in m_User.Posts)
            {
                DateTime postDate = post.CreatedTime.Value;

                if (isPostInSelectedPeriod(postDate, selectedPeriodOption, now))
                {
                    counter++;
                }
            }

            return counter;
        }

        private bool isPostInSelectedPeriod(DateTime postDate, string selectedPeriod, DateTime now)
        {
            switch (selectedPeriod)
            {
                case "This Month":
                    return postDate.Year == now.Year && postDate.Month == now.Month;

                case "Last 3 Months":
                    DateTime threeMonthsAgo = now.AddMonths(-3);
                    return postDate > threeMonthsAgo && postDate <= now;

                case "Last 12 Months":
                    DateTime twelveMonthsAgo = now.AddMonths(-12);
                    return postDate > twelveMonthsAgo && postDate <= now;

                case "Last Five Years":
                    DateTime fiveYearsAgo = now.AddYears(-5);
                    return postDate > fiveYearsAgo && postDate <= now;

                case "Last Ten Years":
                    DateTime tenYearsAgo = now.AddYears(-10);
                    return postDate > tenYearsAgo && postDate <= now;

                default:
                    return false;
            }
        }

        private void showGuessPostYear()
        {
            m_PostToGuess = m_RandomSelector.GetRandomPost();
            visibleObejctsOfGuessPostYear();

            labelSelectedPost.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
            labelSelectedPost.ForeColor = Color.Black;
        }

        private void visibleObejctsOfGuessPostYear()
        {
            labelGuessPost.Visible = true;
            comboBoxGuessPostYear.Visible = true;
            buttonGuessYear.Visible = true;
            buttonNewPostGuess.Visible = true;
            labelSelectedPost.Visible = true;
        }


        private void comboBoxStatistical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNumberOfPostPeriodsOfTime.SelectedIndex != -1)
            {
                buttonNumberOfPostInPeriodOfTime.Enabled = true;
            }
            else
            {
                buttonNumberOfPostInPeriodOfTime.Enabled = false;
            }
        }

        private void buttonGuessYear_Click(object sender, EventArgs e)
        {
            string selectedYearOption = comboBoxGuessPostYear.SelectedItem.ToString();
            if(selectedYearOption == m_PostToGuess.CreatedTime.Value.Year.ToString())
            {
                labelSelectedPost.Text = "YOUR GUESS IS CORRECT!!!";
                labelSelectedPost.ForeColor = Color.PaleGreen;
            }
            else
            {
                labelSelectedPost.Text = "your guess is wrong";
                labelSelectedPost.ForeColor = Color.Red;
            }
        }

        private void buttonNewPostGuess_Click(object sender, EventArgs e)
        {
            m_PostToGuess = m_RandomSelector.GetRandomPost();
            
            comboBoxGuessPostYear.Text = "Select Year";
            labelSelectedPost.ForeColor = Color.Black;
            labelSelectedPost.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
        }

        private void buttonNewBirthdayGuess_Click(object sender, EventArgs e)
        {
            m_FriendToGuess = m_RandomSelector.GetRandomFriend();
            comboBoxGuessBirthdayMonth.Text = "Select Month";
            labelFriendName.ForeColor = Color.Black;
            labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
        }

        private void buttonGuessBirthdayMonth_Click(object sender, EventArgs e)
        {
            int selectedMonthNumber = MonthConverter.GetMonthNumber(comboBoxGuessBirthdayMonth.SelectedItem.ToString());

            if (selectedMonthNumber == m_PostToGuess.CreatedTime.Value.Month)
            {
                labelFriendName.Text = "YOUR GUESS IS CORRECT!!!";          
                labelFriendName.ForeColor = Color.PaleGreen;
            }
            else
            {
                labelFriendName.Text = "your guess is wrong";
                labelFriendName.ForeColor = Color.Red;
            }
        }
    }
}





