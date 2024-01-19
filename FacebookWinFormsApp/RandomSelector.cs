﻿using FacebookWrapper.ObjectModel;
using System;

namespace BasicFacebookFeatures
{
    public class RandomSelector
    {
        private User m_User;
        private Random m_Random = new Random();

        public RandomSelector(User i_user)
        {
            this.m_User = i_user;
        }

        public Post GetRandomPost()
        {
            string postText;
            int randomIndex;
            Post post = null;

            if (m_User.Posts.Count != 0)
            {
                do
                {
                    randomIndex = m_Random.Next(m_User.Posts.Count);
                    post = m_User.Posts[randomIndex];
                    postText = post?.Message;
                }
                while (string.IsNullOrWhiteSpace(postText) || postText == null);
            }

            return post;
        }

        public User GetRandomFriend()
        {
            int randomIndex;
            User user = null;
            if (m_User.Friends.Count != 0)
            {
                randomIndex = m_Random.Next(m_User.Friends.Count);
                user = m_User.Friends[randomIndex];
            }

            return user;
        }
    }
}