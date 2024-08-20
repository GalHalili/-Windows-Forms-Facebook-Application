using FacebookWrapper.ObjectModel;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormFilterFriends : Form
    {
        private const string k_GroupLink = "https://www.facebook.com/share/KSTYh7VQqk8NVcyz/?mibextid=K35XfP";
        private IFilterStrategy m_FilterStrategy = new EqualFeatureFilterStrategy();
        private FacadeFilterFriends m_FacadeFilterFriends = new FacadeFilterFriends();

        public FormFilterFriends()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            populateCheckedListBoxFilterFeatures();
            populateComboBoxPrivacy();
        }

        private void populateCheckedListBoxFilterFeatures()
        {
            checkedListBoxFilterFeatures.Items.Clear();

            foreach (string feature in m_FacadeFilterFriends.GetFilterFeatures())
            {
                checkedListBoxFilterFeatures.Items.Add(feature);
            }
        }

        private void populateComboBoxPrivacy()
        {
            foreach (Group.ePrivacy privacyType in Enum.GetValues(typeof(Group.ePrivacy)))
            {
                comboBoxPrivacy.Items.Add(privacyType);
            }
        }

        private void buttonCreateGroup_Click(object sender, EventArgs e)
        {
            if (m_FacadeFilterFriends.CheckIfLoggedInUser())
            {
                if (checkIfGroupCreationIsLegal())
                {
                    string groupName = titleledTextBoxGroupName.UserText;
                    string groupPrivacy = comboBoxPrivacy.SelectedItem.ToString();
                    if (m_FacadeFilterFriends.CreateFBGroupAndCheckIfSucceed(groupName, groupPrivacy, k_GroupLink,m_FacadeFilterFriends.GetLoginResult()))
                    {
                        MessageBox.Show("Group created successfully!");
                        m_FacadeFilterFriends.SendEmails(groupName, k_GroupLink, m_FacadeFilterFriends.GetFilteredFriendsEmailsList(),
                            m_FacadeFilterFriends.GetLoggedInUser());
                        m_FacadeFilterFriends.WaitForEmailToSend();
                        this.BeginInvoke(new Action(() =>
                        {
                            if (m_FacadeFilterFriends.CheckIfEmailsSendingSucceed())
                            {
                                MessageBox.Show("All emails have been sent successfully");
                            }
                            else
                            {
                                MessageBox.Show("An error occurred - sending some of the emails failed");
                            }
                        }));
                    }
                    else
                    {
                        MessageBox.Show("Group creation failed :(");
                    }
                }
            }
            else
            {
                FormMain.DisplayIfNotLoggedInUser();
            }
        }

        private bool checkIfGroupCreationIsLegal()
        {
            bool isGroupCreationLegal = true;

            if (m_FacadeFilterFriends.CheckIfEmptyFilteredFriendsList())
            {
                isGroupCreationLegal = false;
                MessageBox.Show("According to the selected filter, no friends were found to create a group with");
            }
            else if (!m_FacadeFilterFriends.CheckIfLegaleGroupName(titleledTextBoxGroupName.UserText))
            {
                isGroupCreationLegal = false;
                MessageBox.Show("No name was chosen for the group");
            }
            else if (!m_FacadeFilterFriends.CheckIfLegaleGroupPrivacy(comboBoxPrivacy.SelectedItem))
            {
                isGroupCreationLegal = false;
                MessageBox.Show("No privacy was chosen for the group");
            }

            return isGroupCreationLegal;
        }

        private void buttonShowFilteredFriendsList_Click(object sender, EventArgs e)
        {
            if (m_FacadeFilterFriends.CheckIfLoggedInUser())
            {
                m_FacadeFilterFriends.SetFilterStrategy(m_FilterStrategy);    
                m_FacadeFilterFriends.GetFilteredFriendsList().Clear();
                listBoxFriendsListAfterFilter.Items.Clear();
                checkedListBoxFilterFeatures.ClearSelected();
                fetchFriendsByUserFilterFeaturesSelection();
                m_FacadeFilterFriends.FetchEmailsFromFriendsListAferFilter();
            }
            else
            {
                FormMain.DisplayIfNotLoggedInUser();
            }
        }

        private void fetchFriendsByUserFilterFeaturesSelection()
        {
            listBoxFriendsListAfterFilter.DisplayMember = "Name";
            m_FacadeFilterFriends.FetchFriendsByUserFilterFeaturesSelection(checkedListBoxFilterFeatures.CheckedItems.Cast<string>().ToList());
            foreach (User friend in m_FacadeFilterFriends.GetFilteredFriendsList())
            {
                listBoxFriendsListAfterFilter.Items.Add(friend);
            }

            if (m_FacadeFilterFriends.CheckIfEmptyFilteredFriendsList())
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }
    }
}