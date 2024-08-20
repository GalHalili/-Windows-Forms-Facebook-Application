using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace BasicFacebookFeatures
{
    public sealed class SingletonFormMainLogic
    {
        private static ManualResetEvent s_LoginCompleted = new ManualResetEvent(false);
        public User LoggedInUser { get; set; }
        public LoginResult LoginResult { get; set; } = new LoginResult();
        public static bool IsLoggedInUser { get; set; } = false;

        public static SingletonFormMainLogic Instance
        {
            get { return Singleton<SingletonFormMainLogic>.Instance; }
        }

        private SingletonFormMainLogic(){ }

        public void StartLoginInNewThread(string i_AppID)
        {
            Thread thread = new Thread(() => 
            { 
                startLogin(i_AppID);
            });

            thread.Start(); 
        }

        private void startLogin(string i_AppID)
        {
            login(i_AppID);
            if (IsLoggedInUser)
            {
                LoggedInUser = LoginResult.LoggedInUser;
            }

            s_LoginCompleted.Set();
        }

        private void login(string i_AppID)
        {
            LoginResult = FacebookService.Login(
                i_AppID,
                /// requested permissions:
                "email",
                "public_profile",
                //"pages_read_user_content",
                "user_likes",
                "user_posts",
                "user_photos",
                "user_events",
                "user_videos",
                "user_friends",
                "user_location",
                "user_birthday",
                "user_hometown",
                "user_likes",
                "user_gender"//,
                //"groups_access_member_info"
                );

            IsLoggedInUser = CheckIfLogInSucceed(LoginResult.ErrorMessage);
        }

        public void Logout()
        {
            LoginResult = null;
            IsLoggedInUser = false;
        }

        public bool CheckLoggedInUser(string i_AccessToken)
        {
            return !string.IsNullOrEmpty(i_AccessToken);
        }

        public bool CheckIfLogInSucceed(string i_ErrorMessage)
        {
            return string.IsNullOrEmpty(i_ErrorMessage);
        }

        public void WaitForEmailsToSend()
        {
            s_LoginCompleted.WaitOne();
        }

        public List<Album> GetLoggedInUserAlbums()
        {
            return LoggedInUser.Albums.ToList();
        }

        public List<Group> GetLoggedInUserGroups()
        {
            return LoggedInUser.Groups.ToList();
        }

        public List<Event> GetLoggedInUserEvents()
        {
            return LoggedInUser.Events.ToList();
        }
    }
}