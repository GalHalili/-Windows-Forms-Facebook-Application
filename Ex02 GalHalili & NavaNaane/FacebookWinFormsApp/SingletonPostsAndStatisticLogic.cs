using System;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public sealed class SingletonPostsAndStatisticLogic
    {
        public Screenshot StatisticDataScreenshot { get; set; } = new Screenshot();
        public PostStatisticData PostStatisticData { get; set; } = new PostStatisticData();

        public static SingletonPostsAndStatisticLogic Instance
        {
            get { return Singleton<SingletonPostsAndStatisticLogic>.Instance; }
        }

        private SingletonPostsAndStatisticLogic() { }

        public void SetPostForStatistics(User i_User, int i_SelectedPostIndex)
        {
            PostStatisticData.Post = i_User.Posts[i_SelectedPostIndex];
        }

        public bool PostStatusAndCheckIfSucceed(string i_PostText)
        {
            bool isPostSucceed = false;

            try
            {
                Status statusToPost = SingletonFormMainLogic.Instance.LoggedInUser.PostStatus(i_PostText);

            }
            catch (Exception)
            {
                isPostSucceed = false;
            }

            return isPostSucceed;
        }
    }
}