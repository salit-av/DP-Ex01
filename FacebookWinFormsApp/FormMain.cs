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
                if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
                {
                    m_User = m_LoginResult.LoggedInUser;
                    m_RandomSelector = new RandomSelector(m_User);
                    buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                    buttonLogin.BackColor = Color.LightGreen;
                    enableButtonsAfterLogin();
                }
                else
                {
                    m_LoginResult = null;
                }
            }
          
        }

        private void enableButtonsAfterLogin()
        {
            comboBoxNumberOfPostPeriodsOfTime.Enabled = true;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;
            buttonBirthdayCountdown.Enabled = true;
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
            buttonBirthdayCountdown.Enabled = false;
            comboBoxNumberOfPostPeriodsOfTime.Enabled = false;
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
            buttonNumberOfPostInPeriodOfTime.Enabled = comboBoxNumberOfPostPeriodsOfTime.SelectedIndex != -1;
        }

        private void comboBoxGuessBirthdayMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGuessBirthdayMonth.Enabled = comboBoxGuessBirthdayMonth.SelectedIndex != -1;
        }

        private void comboBoxGuessPostYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGuessYear.Enabled = comboBoxGuessPostYear.SelectedIndex != -1;
        }

        private void buttonGuessYear_Click(object sender, EventArgs e)
        {
            if (m_PostToGuess != null)
            {
                string selectedYearOption = comboBoxGuessPostYear.SelectedItem.ToString();
                if (selectedYearOption == m_PostToGuess.CreatedTime.Value.Year.ToString())
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
        }

        private void buttonNewPostGuess_Click(object sender, EventArgs e)
        {
            m_PostToGuess = m_RandomSelector.GetRandomPost();
            labelSelectedPost.ForeColor = Color.Black;
            labelSelectedPost.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
        }

        private void buttonNewBirthdayGuess_Click(object sender, EventArgs e)
        {
            m_FriendToGuess = m_RandomSelector.GetRandomFriend();
            labelFriendName.ForeColor = Color.Black;
            labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
        }

        private void buttonGuessBirthdayMonth_Click(object sender, EventArgs e)
        {
            if (m_FriendToGuess != null)
            {
                int selectedMonthNumber = MonthConverter.GetMonthNumber(comboBoxGuessBirthdayMonth.SelectedItem.ToString());
                Birthday friendBirthday = new Birthday(m_FriendToGuess.Birthday);

                if (selectedMonthNumber == friendBirthday.getBirthdayMonth())
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
}





