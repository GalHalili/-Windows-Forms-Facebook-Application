using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormPostsAndStatistic : Form
    {
        private const int k_ScreenshotX = 1200;
        private const int k_ScreenshotY = 270;
        private const int k_ScreenshotWidth = 360;
        private const int k_ScreenshotHeight = 500;
        private bool m_IsUserClickedShowStatistics = false;
        private FacadePostsAndStatistic m_FacadePosts = new FacadePostsAndStatistic();

        public FormPostsAndStatistic()
        {
            InitializeComponent();
        }

        private void buttonSetStatus_Click(object sender, EventArgs e)
        {
            if (m_FacadePosts.CheckIfLoggedInUser())
            {
                if (m_FacadePosts.PostStatusAndCheckIfSucceed(titleledTextBoxPost.UserText))
                {
                    MessageBox.Show("Status Posted!");
                }
                else
                {
                    //Today there is no permission to publish posts, the failure message will always be displayed
                    MessageBox.Show("Failed to upload post");
                }
            }
            else
            {
                FormMain.DisplayIfNotLoggedInUser();
            }
        }

        private void linkLabelFetchPosts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_FacadePosts.CheckIfLoggedInUser())
            {
                fetchPosts();
            }
            else
            {
                FormMain.DisplayIfNotLoggedInUser();
            }
        }

        private void fetchPosts()
        {
            postBindingSource.DataSource = m_FacadePosts.GetLoggedInUser().Posts;
            if (listBoxPostType.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void updateStatisticDataLabels()
        {
            titledDataLabelComments.DataText = m_FacadePosts.GetPostCommentsNum().ToString();
            titledDataLabelLikes.DataText = m_FacadePosts.GetPostLikesNum().ToString();
            titledDataLabelFemaleLikes.DataText = m_FacadePosts.GetPostFemaleLikesNum().ToString();
            titledDataLabelMaleLikes.DataText = m_FacadePosts.GetPostMaleLikesNum().ToString();
        }

        private void listBoxPostType_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_FacadePosts.SetPostForStatistics(m_FacadePosts.GetLoggedInUser(), listBoxPostType.SelectedIndex);
        }

        private void buttonShowStatistics_Click(object sender, EventArgs e)
        {
            if (m_FacadePosts.CheckIfLoggedInUser())
            {
                if (listBoxPostType.SelectedIndex > -1)
                {
                    m_FacadePosts.InitializePostStatistic();
                    updateStatisticDataLabels();
                    m_IsUserClickedShowStatistics = true;
                }
                else
                {
                    MessageBox.Show("No post was selected");
                }
            }
            else
            {
                FormMain.DisplayIfNotLoggedInUser();
            }
        }

        private void buttonSavePostStatistics_Click(object sender, EventArgs e)
        {
            if (m_FacadePosts.CheckIfLoggedInUser())
            {
                if (m_IsUserClickedShowStatistics)
                {
                    m_FacadePosts.SetScreenSection(k_ScreenshotX, k_ScreenshotY, k_ScreenshotWidth, k_ScreenshotHeight);
                    if (m_FacadePosts.TakeScreenshotAndCheckIfSucceed())
                    {
                        MessageBox.Show("Screenshot saved successfully");
                    }
                    else
                    {
                        MessageBox.Show("Screenshot faild");
                    }
                }
                else
                {
                    MessageBox.Show("No statistics to save");
                }
            }
            else
            {
                FormMain.DisplayIfNotLoggedInUser();
            }
        }
    }
}