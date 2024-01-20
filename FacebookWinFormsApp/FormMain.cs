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
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                buttonBirthday.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
            buttonStatistical.Enabled = false;
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
            setRandomFriend();
            labelInDevelopment.Visible = true;
            labelGuessFriendBirthday.Visible = true;
            labelFriendName.Visible = true;
            labelFriendName.Text = (m_FriendToGuess == null) ? "No friends exists!" : m_FriendToGuess.Name;
            comboBoxGuessBirthdayMonth.Visible = true;
            buttonGuessBirthdayMonth.Visible = true;
            buttonNewBirthdayGuess.Visible = true;

        }

        private void setRandomFriend()
        {
            int randomIndex;
            Random random = new Random();

            if (m_User.Friends.Count != 0)
            {
                randomIndex = random.Next(m_User.Friends.Count);
                m_FriendToGuess = m_User.Friends[randomIndex];
            }
        }


        private void buttonStatistical_Click(object sender, EventArgs e)
        {
            labelPleaseWait.Visible = true;
            labelPleaseWait.Text = "Please wait...";

            labelStatisicalResult.Visible = true;
            labelStatisicalResult.Text = $"{getNumberOfPostInRequestedTimePeriod()} posts found";

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
            string selectedPeriodOption = comboBoxStatistical.SelectedItem.ToString();
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

                case "This Year":
                    return postDate.Year == now.Year;

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
            setRandomPost();
            labelGuessPost.Visible = true;
            labelSelectedPost.Visible = true;
            labelSelectedPost.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
            labelSelectedPost.ForeColor = Color.Black;
            comboBoxGuessPostYear.Visible = true;
            buttonGuessYear.Visible = true;
            buttonNewPostGuess.Visible = true;
        }

        private void setRandomPost()
        {
            string postText;
            int randomIndex;
            Random random = new Random();

            if (m_User.Posts.Count != 0)
            {
                do
                {
                    randomIndex = random.Next(m_User.Posts.Count);
                    m_PostToGuess = m_User.Posts[randomIndex];
                    postText = m_PostToGuess?.Message;
                }
                while (string.IsNullOrWhiteSpace(postText) || postText == null);
            }
        }


        private void comboBoxStatistical_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxStatistical.SelectedIndex != -1)
            {
                buttonStatistical.Enabled = true;
            }
            else
            {
                buttonStatistical.Enabled = false;
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

        private void buttonNewGuess_Click(object sender, EventArgs e)
        {
            setRandomPost();
            labelSelectedPost.ForeColor = Color.Black;
            labelSelectedPost.Text = (m_PostToGuess == null) ? "No posts exists!" : m_PostToGuess.Message;
        }

        private void buttonNewBirthdayGuess_Click(object sender, EventArgs e)
        {
            setRandomFriend();
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





