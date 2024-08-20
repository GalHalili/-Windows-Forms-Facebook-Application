using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class FacadeFilterFriends
    {
        private ProxyFormMainFacade m_FacadeFormMain = new ProxyFormMainFacade();

        public string[] GetFilterFeatures()
        {
            return SingletonFilterFriendsLogic.Instance.FilterFeatures;
        }

        public bool CreateFBGroupAndCheckIfSucceed(string i_GroupName, string i_GroupPrivacy, string i_GroupLink, LoginResult i_LoginResult)
        {
            return FBGroup.CreateFBGroupAndCheckIfSucceed(i_GroupName, i_GroupPrivacy, i_GroupLink, i_LoginResult);
        }

        public void SendEmails(string i_GroupName, string i_GroupLink, List<string> i_EmailsList, User i_LoggedInUser)
        {
            EmailSender.SendEmailsInNewThread(i_GroupName, i_GroupLink, i_EmailsList, i_LoggedInUser);
        }

        public void WaitForEmailToSend()
        {
            EmailSender.WaitForEmailToSend();
        }

        public bool CheckIfEmailsSendingSucceed()
        {
            return EmailSender.IsEmailSendingSucceed;
        }

        public List<string> GetFilteredFriendsEmailsList()
        {
            return SingletonFilterFriendsLogic.Instance.FilteredFriendsEmailsList;
        }

        public bool CheckIfEmptyFilteredFriendsList()
        {
            return SingletonFilterFriendsLogic.Instance.CheckIfEmptyFilteredFriendsList();
        }

        public bool CheckIfLegaleGroupName(string i_GroupName)
        {
            return FBGroup.CheckIfLegaleGroupName(i_GroupName);
        }

        public bool CheckIfLegaleGroupPrivacy(object i_GroupPrivacy)
        {
            return FBGroup.CheckIfLegaleGroupPrivacy(i_GroupPrivacy);
        }

        public List<User> GetFilteredFriendsList()
        {
            return SingletonFilterFriendsLogic.Instance.FilteredFriendsList;
        }

        public void FetchEmailsFromFriendsListAferFilter()
        {
            SingletonFilterFriendsLogic.Instance.FetchEmailsFromFriendsListAferFilter();
        }

        public void FetchFriendsByUserFilterFeaturesSelection(ICollection<string> i_CheckedFilterFeatures)
        {
            SingletonFilterFriendsLogic.Instance.FetchFriendsByUserFilterFeaturesSelection(i_CheckedFilterFeatures);
        }

        public void SetFilterStrategy(IFilterStrategy i_FilterStrategy)
        {
            SingletonFilterFriendsLogic.Instance.FilterStrategy = i_FilterStrategy;
        }

        public User GetLoggedInUser()
        {
            return m_FacadeFormMain.GetLoggedInUser();
        }

        public LoginResult GetLoginResult()
        {
            return m_FacadeFormMain.GetLoginResult();
        }

        public bool CheckIfLoggedInUser()
        {
            return m_FacadeFormMain.CheckIfLoggedInUser();
        }
    }
}