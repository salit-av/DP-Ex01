using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FacebookAuthManager
    {
        private LoginResult m_LoginResult;
        internal User m_LoggedInUser { get; private set; }

        internal bool Login(string appId, params string[] permissions)
        {
            m_LoginResult = FacebookService.Login(appId, permissions);

            if (!string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                return false;
            }
            else if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                m_LoggedInUser = m_LoginResult.LoggedInUser;
                return true;
            }

            return false;
        }

        internal void Logout()
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
        }
    }

}
