using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacebookAuthManager
    {
        private LoginResult m_LoginResult;
        public User LoggedInUser { get; private set; }

        public bool Login(string appId, params string[] permissions)
        {
            m_LoginResult = FacebookService.Login(appId, permissions);

            if (!string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                // Handle error message, maybe log it or show to the user
                return false;
            }
            else if (!string.IsNullOrEmpty(m_LoginResult.AccessToken))
            {
                LoggedInUser = m_LoginResult.LoggedInUser;
                return true;
            }

            return false;
        }

        public void Logout()
        {
            FacebookService.LogoutWithUI();
            LoggedInUser = null;
        }
    }

}
