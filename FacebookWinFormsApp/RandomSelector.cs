using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class RandomSelector
    {
        private User m_User;
        private Random m_Random = new Random();

        internal RandomSelector(User i_user)
        {
            this.m_User = i_user;
        }

        internal Post GetRandomPost()
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

        internal User GetRandomFriend()
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