using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FormFilterFriends m_FormFilterFriends = null;
        private FormPostsAndStatistic m_FormPostsAndStatistic = null;
        private ProxyFormMainFacade m_FacadeFormMain = new ProxyFormMainFacade();

        public FormMain()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (m_FacadeFormMain.GetLoginResult() == null || !m_FacadeFormMain.CheckIfLoggedInUserByAccessToken(m_FacadeFormMain.GetLoginResult().AccessToken))
            {
                m_FacadeFormMain.StartLogin(textBoxAppID.Text);
                m_FacadeFormMain.WaitForLoginToComplete(); 
                loginUIChanges();
            }
        }

        private void loginUIChanges()
        {
            if (m_FacadeFormMain.CheckIfLoggedInUser())
            {
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_FacadeFormMain.GetLoggedInUser().PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_FacadeFormMain.Logout();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void titledListBoxAlbums_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_FacadeFormMain.CheckIfLoggedInUser())
            {
                fetchAlbums();
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void fetchAlbums()
        {
            albumBindingSource.DataSource = m_FacadeFormMain.GetLoggedInUserAlbums();
            if (listBoxAlbums.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void titledListBoxGroups_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_FacadeFormMain.CheckIfLoggedInUser())
            {
                fetchGroups();
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void fetchGroups()
        {
            groupBindingSource.DataSource = m_FacadeFormMain.GetLoggedInUserGroups();
            if (listBoxGroups.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void titledListBoxEvents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (m_FacadeFormMain.CheckIfLoggedInUser())
            {
                fetchEvents();
            }
            else
            {
                DisplayIfNotLoggedInUser();
            }
        }

        private void fetchEvents()
        {
            eventBindingSource.DataSource = m_FacadeFormMain.GetLoggedInUserEvents();
            if (listBoxEvents.Items.Count == 0)
            {
                MessageBox.Show("No events to retrieve :(");
            }
        }

        private void buttonFilterFriends_Click(object sender, EventArgs e)
        {
            if (m_FormFilterFriends == null)
            {
                m_FormFilterFriends = new FormFilterFriends();
            }

            m_FormFilterFriends.ShowDialog();
        }

        private void buttonPostsAndStatistics_Click(object sender, EventArgs e)
        {
            if (m_FormPostsAndStatistic == null)
            {
                m_FormPostsAndStatistic = new FormPostsAndStatistic();
            }

            m_FormPostsAndStatistic.ShowDialog();
        }

        public static void DisplayIfNotLoggedInUser()
        {
            MessageBox.Show("You have to login");
        }
    }
}