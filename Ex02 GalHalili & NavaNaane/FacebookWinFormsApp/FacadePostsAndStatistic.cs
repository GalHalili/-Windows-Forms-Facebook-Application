using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class FacadePostsAndStatistic
    {
        private ProxyFormMainFacade m_FacadeFormMain = new ProxyFormMainFacade();

        public bool PostStatusAndCheckIfSucceed(string i_PostText)
        {
            return SingletonPostsAndStatisticLogic.Instance.PostStatusAndCheckIfSucceed(i_PostText);
        }

        public void SetPostForStatistics(User i_User, int i_SelectedPostIndex)
        {
            SingletonPostsAndStatisticLogic.Instance.SetPostForStatistics(i_User, i_SelectedPostIndex);
        }

        public void SetScreenSection(int i_X, int i_Y, int i_Width, int i_Height)
        {
            SingletonPostsAndStatisticLogic.Instance.StatisticDataScreenshot.SetScreenSection(i_X, i_Y, i_Width, i_Height);
        }

        public bool TakeScreenshotAndCheckIfSucceed()
        {
            return SingletonPostsAndStatisticLogic.Instance.StatisticDataScreenshot.TakeScreenshotAndCheckIfSucceed();
        }

        public int GetPostCommentsNum()
        {
            return SingletonPostsAndStatisticLogic.Instance.PostStatisticData.CommentsNum;
        }

        public int GetPostLikesNum()
        {
            return SingletonPostsAndStatisticLogic.Instance.PostStatisticData.LikesNum;
        }

        public int GetPostFemaleLikesNum()
        {
            return SingletonPostsAndStatisticLogic.Instance.PostStatisticData.FemaleLikesNum;
        }

        public int GetPostMaleLikesNum()
        {
            return SingletonPostsAndStatisticLogic.Instance.PostStatisticData.MaleLikesNum;
        }

        public void InitializePostStatistic()
        {
            SingletonPostsAndStatisticLogic.Instance.PostStatisticData.InitializePostStatistic();
        }

        public User GetLoggedInUser()
        {
            return m_FacadeFormMain.GetLoggedInUser();
        }

        public bool CheckIfLoggedInUser()
        {
            return m_FacadeFormMain.CheckIfLoggedInUser();
        }
    }
}