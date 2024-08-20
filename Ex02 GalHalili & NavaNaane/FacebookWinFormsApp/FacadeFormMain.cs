using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class FacadeFormMain
    {
        public LoginResult GetLoginResult() 
        {
            return SingletonFormMainLogic.Instance.LoginResult;
        }

        public User GetLoggedInUser()
        {
            return SingletonFormMainLogic.Instance.LoggedInUser;
        }

        public bool CheckIfLoggedInUser()
        {
            return SingletonFormMainLogic.IsLoggedInUser;
        }

        public bool CheckIfLoggedInUserByAccessToken(string i_AccessToken)
        {
            return SingletonFormMainLogic.Instance.CheckLoggedInUser(i_AccessToken);
        }

        public void StartLogin(string i_AppID)
        {
            SingletonFormMainLogic.Instance.StartLoginInNewThread(i_AppID);
        }

        public void WaitForLoginToComplete()
        {
            SingletonFormMainLogic.Instance.WaitForEmailsToSend();
        }

        public List<Album> GetLoggedInUserAlbums()
        {
            return SingletonFormMainLogic.Instance.GetLoggedInUserAlbums();
        }

        public List<Group> GetLoggedInUserGroups()
        {
            return SingletonFormMainLogic.Instance.GetLoggedInUserGroups();
        }

        public List<Event> GetLoggedInUserEvents()
        {
            return SingletonFormMainLogic.Instance.GetLoggedInUserEvents();
        }

        public void Logout()
        {
            SingletonFormMainLogic.Instance.Logout();
        }
    }
}