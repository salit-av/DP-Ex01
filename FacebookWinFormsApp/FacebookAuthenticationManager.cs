using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FacebookAuthenticationManager
    {
        private LoginResult m_LoginResult;
        internal User m_LoggedInUser { get; private set; }

        internal bool Login(string appId, params string[] permissions)
        {
            bool isLoginSucceeded = false;
            m_LoginResult = FacebookService.Login(appId, permissions);
            
            if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                isLoginSucceeded = true;
            }

            return isLoginSucceeded;
        }

        internal void Logout()
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
        }
    }
}