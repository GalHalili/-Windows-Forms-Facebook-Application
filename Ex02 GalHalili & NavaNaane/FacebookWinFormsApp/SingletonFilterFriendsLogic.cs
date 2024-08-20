using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public sealed class SingletonFilterFriendsLogic
    {
        public IFilterStrategy FilterStrategy { get; set; }
        public List<User> FilteredFriendsList { get; set; } = new List<User>();
        public List<string> FilteredFriendsEmailsList { get; set; } = new List<string> { "galhalili999@gmail.com" };
        //Today it is not possible to fetch the email addresses of friends from Facebook, so we used our email address as an example
        public string[] FilterFeatures { get; } = new string[]
        {
            "Birthday",
            "Gender",
            "Hometown",
            "Location"
        };

        public static SingletonFilterFriendsLogic Instance
        {
            get { return Singleton<SingletonFilterFriendsLogic>.Instance; }
        }

        private SingletonFilterFriendsLogic() { }

        public void FetchEmailsFromFriendsListAferFilter()
        {
            foreach (User fbFriend in FilteredFriendsList)
            {
                if (fbFriend.Email != null)
                {
                    FilteredFriendsEmailsList.Add(fbFriend.Email);
                }
            }
        }

        public void FetchFriendsByUserFilterFeaturesSelection(ICollection<string> i_CheckedFilterFeatures)
        {
            foreach (User fbFriend in SingletonFormMainLogic.Instance.LoggedInUser.Friends)
            {
                if (i_CheckedFilterFeatures.Contains("Birthday"))
                {
                    if (!FilterStrategy.ShouldFilterBirthday(SingletonFormMainLogic.Instance.LoggedInUser.Birthday, fbFriend.Birthday))
                    {
                        break;
                    }
                }

                if (i_CheckedFilterFeatures.Contains("Gender"))
                {
                    if (!FilterStrategy.ShouldFilterGender(SingletonFormMainLogic.Instance.LoggedInUser.Gender, fbFriend.Gender))
                    {
                        break;
                    }
                }

                if (i_CheckedFilterFeatures.Contains("Hometown"))
                {
                    if (!FilterStrategy.ShouldFilterHometown(SingletonFormMainLogic.Instance.LoggedInUser.Hometown, fbFriend.Hometown))
                    {
                        break;
                    }
                }

                if (i_CheckedFilterFeatures.Contains("Location"))
                {
                    if (!FilterStrategy.ShouldFilterLocation(SingletonFormMainLogic.Instance.LoggedInUser.Location, fbFriend.Location))
                    {
                        break;
                    }
                }

                FilteredFriendsList.Add(fbFriend);
            }
        }

        public bool CheckIfEmptyFilteredFriendsList()
        {
            return FilteredFriendsList.Count == 0;
        }
    }
}