using System;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelWinFormTitle = new System.Windows.Forms.Label();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNewBirthdayGuess = new System.Windows.Forms.Button();
            this.labelInDevelopment = new System.Windows.Forms.Label();
            this.labelFriendName = new System.Windows.Forms.Label();
            this.buttonGuessBirthdayMonth = new System.Windows.Forms.Button();
            this.comboBoxGuessBirthdayMonth = new System.Windows.Forms.ComboBox();
            this.labelGuessFriendBirthday = new System.Windows.Forms.Label();
            this.labelBirthdayExplain = new System.Windows.Forms.Label();
            this.labelBirthday = new System.Windows.Forms.Label();
            this.labelBirthdayCountdown = new System.Windows.Forms.Label();
            this.buttonBirthday = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNewPostGuess = new System.Windows.Forms.Button();
            this.labelPleaseWait = new System.Windows.Forms.Label();
            this.labelSelectedPost = new System.Windows.Forms.Label();
            this.buttonGuessYear = new System.Windows.Forms.Button();
            this.comboBoxGuessPostYear = new System.Windows.Forms.ComboBox();
            this.labelGuessPost = new System.Windows.Forms.Label();
            this.labelNumberOfPostExplain = new System.Windows.Forms.Label();
            this.labelPostsData = new System.Windows.Forms.Label();
            this.buttonNumberOfPostInPeriodOfTime = new System.Windows.Forms.Button();
            this.labelNumberOfPostsInPeriodOfTime = new System.Windows.Forms.Label();
            this.comboBoxNumberOfPostPeriodsOfTime = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightCyan;
            this.tabPage1.Controls.Add(this.labelWinFormTitle);
            this.tabPage1.Controls.Add(this.buttonLogout);
            this.tabPage1.Controls.Add(this.buttonLogin);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1235, 666);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "FacebookWinFormsApp";
            // 
            // labelWinFormTitle
            // 
            this.labelWinFormTitle.AutoSize = true;
            this.labelWinFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinFormTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelWinFormTitle.Location = new System.Drawing.Point(207, 27);
            this.labelWinFormTitle.Name = "labelWinFormTitle";
            this.labelWinFormTitle.Size = new System.Drawing.Size(911, 54);
            this.labelWinFormTitle.TabIndex = 63;
            this.labelWinFormTitle.Text = "WELCOME TO FACEBOOK STATISTIC!";
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 63);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(148, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(148, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.buttonNewBirthdayGuess);
            this.panel1.Controls.Add(this.labelInDevelopment);
            this.panel1.Controls.Add(this.labelFriendName);
            this.panel1.Controls.Add(this.buttonGuessBirthdayMonth);
            this.panel1.Controls.Add(this.comboBoxGuessBirthdayMonth);
            this.panel1.Controls.Add(this.labelGuessFriendBirthday);
            this.panel1.Controls.Add(this.labelBirthdayExplain);
            this.panel1.Controls.Add(this.labelBirthday);
            this.panel1.Controls.Add(this.labelBirthdayCountdown);
            this.panel1.Controls.Add(this.buttonBirthday);
            this.panel1.Location = new System.Drawing.Point(635, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 533);
            this.panel1.TabIndex = 64;
            // 
            // buttonNewBirthdayGuess
            // 
            this.buttonNewBirthdayGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewBirthdayGuess.Location = new System.Drawing.Point(398, 479);
            this.buttonNewBirthdayGuess.Name = "buttonNewBirthdayGuess";
            this.buttonNewBirthdayGuess.Size = new System.Drawing.Size(118, 37);
            this.buttonNewBirthdayGuess.TabIndex = 71;
            this.buttonNewBirthdayGuess.Text = "New Guess";
            this.buttonNewBirthdayGuess.UseVisualStyleBackColor = true;
            this.buttonNewBirthdayGuess.Visible = false;
            this.buttonNewBirthdayGuess.Click += new System.EventHandler(this.buttonNewBirthdayGuess_Click);
            // 
            // labelInDevelopment
            // 
            this.labelInDevelopment.BackColor = System.Drawing.Color.Transparent;
            this.labelInDevelopment.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInDevelopment.ForeColor = System.Drawing.Color.Maroon;
            this.labelInDevelopment.Location = new System.Drawing.Point(153, 252);
            this.labelInDevelopment.Name = "labelInDevelopment";
            this.labelInDevelopment.Size = new System.Drawing.Size(292, 42);
            this.labelInDevelopment.TabIndex = 70;
            this.labelInDevelopment.Text = "In Development";
            this.labelInDevelopment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInDevelopment.Visible = false;
            // 
            // labelFriendName
            // 
            this.labelFriendName.AutoSize = true;
            this.labelFriendName.ForeColor = System.Drawing.Color.LightGray;
            this.labelFriendName.Location = new System.Drawing.Point(253, 379);
            this.labelFriendName.Name = "labelFriendName";
            this.labelFriendName.Size = new System.Drawing.Size(90, 18);
            this.labelFriendName.TabIndex = 69;
            this.labelFriendName.Text = "Friend name";
            this.labelFriendName.Visible = false;
            // 
            // buttonGuessBirthdayMonth
            // 
            this.buttonGuessBirthdayMonth.Enabled = false;
            this.buttonGuessBirthdayMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuessBirthdayMonth.Location = new System.Drawing.Point(233, 479);
            this.buttonGuessBirthdayMonth.Name = "buttonGuessBirthdayMonth";
            this.buttonGuessBirthdayMonth.Size = new System.Drawing.Size(139, 37);
            this.buttonGuessBirthdayMonth.TabIndex = 69;
            this.buttonGuessBirthdayMonth.Text = "Check Yourself";
            this.buttonGuessBirthdayMonth.UseVisualStyleBackColor = true;
            this.buttonGuessBirthdayMonth.Visible = false;
            this.buttonGuessBirthdayMonth.Click += new System.EventHandler(this.buttonGuessBirthdayMonth_Click);
            // 
            // comboBoxGuessBirthdayMonth
            // 
            this.comboBoxGuessBirthdayMonth.Enabled = false;
            this.comboBoxGuessBirthdayMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGuessBirthdayMonth.FormattingEnabled = true;
            this.comboBoxGuessBirthdayMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxGuessBirthdayMonth.Location = new System.Drawing.Point(84, 485);
            this.comboBoxGuessBirthdayMonth.Name = "comboBoxGuessBirthdayMonth";
            this.comboBoxGuessBirthdayMonth.Size = new System.Drawing.Size(121, 26);
            this.comboBoxGuessBirthdayMonth.TabIndex = 69;
            this.comboBoxGuessBirthdayMonth.Text = "Select Month";
            this.comboBoxGuessBirthdayMonth.Visible = false;
            // 
            // labelGuessFriendBirthday
            // 
            this.labelGuessFriendBirthday.AutoSize = true;
            this.labelGuessFriendBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessFriendBirthday.ForeColor = System.Drawing.Color.LightGray;
            this.labelGuessFriendBirthday.Location = new System.Drawing.Point(111, 326);
            this.labelGuessFriendBirthday.Name = "labelGuessFriendBirthday";
            this.labelGuessFriendBirthday.Size = new System.Drawing.Size(386, 18);
            this.labelGuessFriendBirthday.TabIndex = 69;
            this.labelGuessFriendBirthday.Text = "Will you dare to guess your friend birthday month?";
            this.labelGuessFriendBirthday.Visible = false;
            // 
            // labelBirthdayExplain
            // 
            this.labelBirthdayExplain.AutoSize = true;
            this.labelBirthdayExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayExplain.Location = new System.Drawing.Point(157, 76);
            this.labelBirthdayExplain.Name = "labelBirthdayExplain";
            this.labelBirthdayExplain.Size = new System.Drawing.Size(267, 18);
            this.labelBirthdayExplain.TabIndex = 60;
            this.labelBirthdayExplain.Text = " Find out your birthday countdown!";
            // 
            // labelBirthday
            // 
            this.labelBirthday.AutoSize = true;
            this.labelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthday.Location = new System.Drawing.Point(174, 31);
            this.labelBirthday.Name = "labelBirthday";
            this.labelBirthday.Size = new System.Drawing.Size(234, 31);
            this.labelBirthday.TabIndex = 56;
            this.labelBirthday.Text = "Birthday Counter";
            // 
            // labelBirthdayCountdown
            // 
            this.labelBirthdayCountdown.AutoSize = true;
            this.labelBirthdayCountdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthdayCountdown.Location = new System.Drawing.Point(48, 205);
            this.labelBirthdayCountdown.Name = "labelBirthdayCountdown";
            this.labelBirthdayCountdown.Size = new System.Drawing.Size(0, 39);
            this.labelBirthdayCountdown.TabIndex = 59;
            this.labelBirthdayCountdown.Visible = false;
            // 
            // buttonBirthday
            // 
            this.buttonBirthday.Enabled = false;
            this.buttonBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBirthday.Location = new System.Drawing.Point(242, 108);
            this.buttonBirthday.Name = "buttonBirthday";
            this.buttonBirthday.Size = new System.Drawing.Size(101, 37);
            this.buttonBirthday.TabIndex = 60;
            this.buttonBirthday.Text = "Find out!";
            this.buttonBirthday.UseVisualStyleBackColor = true;
            this.buttonBirthday.Click += new System.EventHandler(this.buttonBirthdayCounter_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonNewPostGuess);
            this.panel2.Controls.Add(this.labelPleaseWait);
            this.panel2.Controls.Add(this.labelSelectedPost);
            this.panel2.Controls.Add(this.buttonGuessYear);
            this.panel2.Controls.Add(this.comboBoxGuessPostYear);
            this.panel2.Controls.Add(this.labelGuessPost);
            this.panel2.Controls.Add(this.labelNumberOfPostExplain);
            this.panel2.Controls.Add(this.labelPostsData);
            this.panel2.Controls.Add(this.buttonNumberOfPostInPeriodOfTime);
            this.panel2.Controls.Add(this.labelNumberOfPostsInPeriodOfTime);
            this.panel2.Controls.Add(this.comboBoxNumberOfPostPeriodsOfTime);
            this.panel2.Location = new System.Drawing.Point(18, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(581, 533);
            this.panel2.TabIndex = 65;
            // 
            // buttonNewPostGuess
            // 
            this.buttonNewPostGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewPostGuess.Location = new System.Drawing.Point(374, 478);
            this.buttonNewPostGuess.Name = "buttonNewPostGuess";
            this.buttonNewPostGuess.Size = new System.Drawing.Size(118, 37);
            this.buttonNewPostGuess.TabIndex = 70;
            this.buttonNewPostGuess.Text = "New Guess";
            this.buttonNewPostGuess.UseVisualStyleBackColor = true;
            this.buttonNewPostGuess.Visible = false;
            this.buttonNewPostGuess.Click += new System.EventHandler(this.buttonNewPostGuess_Click);
            // 
            // labelPleaseWait
            // 
            this.labelPleaseWait.AutoSize = true;
            this.labelPleaseWait.Location = new System.Drawing.Point(226, 185);
            this.labelPleaseWait.Name = "labelPleaseWait";
            this.labelPleaseWait.Size = new System.Drawing.Size(95, 18);
            this.labelPleaseWait.TabIndex = 69;
            this.labelPleaseWait.Text = "Please wait...";
            this.labelPleaseWait.Visible = false;
            // 
            // labelSelectedPost
            // 
            this.labelSelectedPost.ForeColor = System.Drawing.Color.Black;
            this.labelSelectedPost.Location = new System.Drawing.Point(72, 258);
            this.labelSelectedPost.Name = "labelSelectedPost";
            this.labelSelectedPost.Size = new System.Drawing.Size(398, 199);
            this.labelSelectedPost.TabIndex = 68;
            this.labelSelectedPost.Text = "Post";
            this.labelSelectedPost.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelSelectedPost.Visible = false;
            // 
            // buttonGuessYear
            // 
            this.buttonGuessYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuessYear.Location = new System.Drawing.Point(211, 478);
            this.buttonGuessYear.Name = "buttonGuessYear";
            this.buttonGuessYear.Size = new System.Drawing.Size(138, 37);
            this.buttonGuessYear.TabIndex = 67;
            this.buttonGuessYear.Text = "Check Yourself";
            this.buttonGuessYear.UseVisualStyleBackColor = true;
            this.buttonGuessYear.Visible = false;
            this.buttonGuessYear.Click += new System.EventHandler(this.buttonGuessYear_Click);
            // 
            // comboBoxGuessPostYear
            // 
            this.comboBoxGuessPostYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGuessPostYear.FormattingEnabled = true;
            this.comboBoxGuessPostYear.Items.AddRange(new object[] {
            "2024",
            "2023",
            "2022",
            "2021",
            "2020",
            "2019",
            "2018",
            "2017",
            "2016",
            "2015",
            "2014"});
            this.comboBoxGuessPostYear.Location = new System.Drawing.Point(75, 484);
            this.comboBoxGuessPostYear.Name = "comboBoxGuessPostYear";
            this.comboBoxGuessPostYear.Size = new System.Drawing.Size(112, 26);
            this.comboBoxGuessPostYear.TabIndex = 66;
            this.comboBoxGuessPostYear.Text = "Select Year";
            this.comboBoxGuessPostYear.Visible = false;
            // 
            // labelGuessPost
            // 
            this.labelGuessPost.AutoSize = true;
            this.labelGuessPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGuessPost.Location = new System.Drawing.Point(55, 225);
            this.labelGuessPost.Name = "labelGuessPost";
            this.labelGuessPost.Size = new System.Drawing.Size(449, 18);
            this.labelGuessPost.TabIndex = 65;
            this.labelGuessPost.Text = "Will you dare to guess when you published the next post?  ";
            this.labelGuessPost.Visible = false;
            // 
            // labelNumberOfPostExplain
            // 
            this.labelNumberOfPostExplain.AutoSize = true;
            this.labelNumberOfPostExplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPostExplain.Location = new System.Drawing.Point(89, 75);
            this.labelNumberOfPostExplain.Name = "labelNumberOfPostExplain";
            this.labelNumberOfPostExplain.Size = new System.Drawing.Size(415, 18);
            this.labelNumberOfPostExplain.TabIndex = 63;
            this.labelNumberOfPostExplain.Text = "Find out how many post you post at the selected time ";
            // 
            // labelPostsData
            // 
            this.labelPostsData.AutoSize = true;
            this.labelPostsData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostsData.Location = new System.Drawing.Point(205, 30);
            this.labelPostsData.Name = "labelPostsData";
            this.labelPostsData.Size = new System.Drawing.Size(153, 31);
            this.labelPostsData.TabIndex = 57;
            this.labelPostsData.Text = "Posts data";
            // 
            // buttonNumberOfPostInPeriodOfTime
            // 
            this.buttonNumberOfPostInPeriodOfTime.Enabled = false;
            this.buttonNumberOfPostInPeriodOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNumberOfPostInPeriodOfTime.Location = new System.Drawing.Point(331, 107);
            this.buttonNumberOfPostInPeriodOfTime.Name = "buttonNumberOfPostInPeriodOfTime";
            this.buttonNumberOfPostInPeriodOfTime.Size = new System.Drawing.Size(101, 37);
            this.buttonNumberOfPostInPeriodOfTime.TabIndex = 58;
            this.buttonNumberOfPostInPeriodOfTime.Text = "Find out!";
            this.buttonNumberOfPostInPeriodOfTime.UseVisualStyleBackColor = true;
            this.buttonNumberOfPostInPeriodOfTime.Click += new System.EventHandler(this.buttonNumberOfPostInPeriodOfTime_Click);
            // 
            // labelNumberOfPostsInPeriodOfTime
            // 
            this.labelNumberOfPostsInPeriodOfTime.AutoSize = true;
            this.labelNumberOfPostsInPeriodOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumberOfPostsInPeriodOfTime.Location = new System.Drawing.Point(174, 172);
            this.labelNumberOfPostsInPeriodOfTime.Name = "labelNumberOfPostsInPeriodOfTime";
            this.labelNumberOfPostsInPeriodOfTime.Size = new System.Drawing.Size(213, 31);
            this.labelNumberOfPostsInPeriodOfTime.TabIndex = 61;
            this.labelNumberOfPostsInPeriodOfTime.Text = "Number of posts";
            this.labelNumberOfPostsInPeriodOfTime.Visible = false;
            // 
            // comboBoxNumberOfPostPeriodsOfTime
            // 
            this.comboBoxNumberOfPostPeriodsOfTime.Enabled = false;
            this.comboBoxNumberOfPostPeriodsOfTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNumberOfPostPeriodsOfTime.FormattingEnabled = true;
            this.comboBoxNumberOfPostPeriodsOfTime.Items.AddRange(new object[] {
            "This Month",
            "Last 3 Months",
            "Last 12 Months",
            "Last Five Years",
            "Last Ten Years"});
            this.comboBoxNumberOfPostPeriodsOfTime.Location = new System.Drawing.Point(126, 113);
            this.comboBoxNumberOfPostPeriodsOfTime.Name = "comboBoxNumberOfPostPeriodsOfTime";
            this.comboBoxNumberOfPostPeriodsOfTime.Size = new System.Drawing.Size(158, 26);
            this.comboBoxNumberOfPostPeriodsOfTime.TabIndex = 62;
            this.comboBoxNumberOfPostPeriodsOfTime.Text = "Select Period";
            this.comboBoxNumberOfPostPeriodsOfTime.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatistical_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1243, 697);
            this.tabControl1.TabIndex = 54;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1243, 697);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookWinFormsApp";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label labelBirthday;
        private System.Windows.Forms.Button buttonNumberOfPostInPeriodOfTime;
        private System.Windows.Forms.Label labelPostsData;
        private System.Windows.Forms.Label labelBirthdayCountdown;
        private System.Windows.Forms.Button buttonBirthday;
        private System.Windows.Forms.Label labelNumberOfPostsInPeriodOfTime;
        private System.Windows.Forms.ComboBox comboBoxNumberOfPostPeriodsOfTime;
        private System.Windows.Forms.Label labelWinFormTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelBirthdayExplain;
        private System.Windows.Forms.Label labelNumberOfPostExplain;
        private System.Windows.Forms.Label labelInDevelopment;
        private System.Windows.Forms.Label labelFriendName;
        private System.Windows.Forms.Button buttonGuessBirthdayMonth;
        private System.Windows.Forms.ComboBox comboBoxGuessBirthdayMonth;
        private System.Windows.Forms.Label labelGuessFriendBirthday;
        private System.Windows.Forms.Label labelSelectedPost;
        private System.Windows.Forms.Button buttonGuessYear;
        private System.Windows.Forms.ComboBox comboBoxGuessPostYear;
        private System.Windows.Forms.Label labelGuessPost;
        private System.Windows.Forms.Label labelPleaseWait;
        private System.Windows.Forms.Button buttonNewPostGuess;
        private System.Windows.Forms.Button buttonNewBirthdayGuess;
    }
}

