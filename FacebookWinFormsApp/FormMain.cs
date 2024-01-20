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
        private FacebookAuthManager m_FacebookAuthManager = new FacebookAuthManager();
        private RandomSelector m_RandomSelector;
        private PostAnalyzer m_PostAnalyzer;
        private Post m_PostToGuess;
        private User m_FriendToGuess;
        private bool m_IsUserGuessedPostYear = false;
        private bool m_IsUserGuessedFriendBirthday = false;
        private User m_User;

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_FacebookAuthManager.LoggedInUser == null)
            {
                if (m_FacebookAuthManager.Login("749307766594184", "email", "public_profile", "user_posts", "user_birthday"))
                {
                    m_User = m_FacebookAuthManager.LoggedInUser;
                    m_RandomSelector = new RandomSelector(m_FacebookAuthManager.LoggedInUser);
                    m_PostAnalyzer = new PostAnalyzer(m_FacebookAuthManager.LoggedInUser);
                    buttonLogin.Text = $"Logged in as {m_FacebookAuthManager.LoggedInUser.Name}";
                    buttonLogin.BackColor = Color.LightGreen;
                    enableButtonsAfterLogin();
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
            m_FacebookAuthManager.Logout();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            disableButtonsAfterLogout();
        }

        private void disableButtonsAfterLogout()
        {
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            buttonNumberOfPostInPeriodOfTime.Enabled = false;
            buttonBirthdayCountdown.Enabled = false;
            comboBoxNumberOfPostPeriodsOfTime.Enabled = false;
        }

        private void buttonBirthdayCounter_Click(object sender, EventArgs e)
        {
            BirthdayFeature birthday = new BirthdayFeature(m_User.Birthday);
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
            string selectedPeriodOption = comboBoxNumberOfPostPeriodsOfTime.SelectedItem.ToString();

            labelPleaseWait.Visible = true;
            labelPleaseWait.Text = "Please wait...";

            labelNumberOfPostsInPeriodOfTime.Visible = true;
            labelNumberOfPostsInPeriodOfTime.Text = $"{m_PostAnalyzer.CountPostsInPeriod(selectedPeriodOption)} posts found";

            labelPleaseWait.Visible = false;

            if (!m_IsUserGuessedPostYear)
            {
                showGuessPostYear();
                m_IsUserGuessedPostYear = true;
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
            comboBoxGuessPostYear.Text = "Select Year";
            labelSelectedPost.ForeColor = Color.Black;
            labelSelectedPost.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
        }

        private void buttonNewBirthdayGuess_Click(object sender, EventArgs e)
        {
            m_FriendToGuess = m_RandomSelector.GetRandomFriend();
            labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
        }

        private void buttonGuessBirthdayMonth_Click(object sender, EventArgs e)
        {
            if (m_FriendToGuess != null)
            {
                int selectedMonthNumber = MonthConverter.GetMonthNumber(comboBoxGuessBirthdayMonth.SelectedItem.ToString());
                BirthdayFeature friendBirthday = new BirthdayFeature(m_FriendToGuess.Birthday);

                if (selectedMonthNumber == friendBirthday.GetBirthdayMonth())
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