using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    class EqualFeatureFilterStrategy : IFilterStrategy
    {
        public bool ShouldFilterBirthday(string i_UserBirthday, string i_FriendBirthday)
        {
            return i_FriendBirthday != null && i_UserBirthday == i_FriendBirthday;
        }

        public bool ShouldFilterGender(User.eGender? i_UserGender, User.eGender? i_FriendGender)
        {
            return i_FriendGender != null && i_UserGender == i_FriendGender;
        }

        public bool ShouldFilterHometown(City i_UserHometown, City i_FriendHometown)
        {
            return i_FriendHometown != null && i_UserHometown == i_FriendHometown;
        }

        public bool ShouldFilterLocation(City i_UserLocation, City i_FriendLocation)
        {
            return i_FriendLocation != null && i_UserLocation == i_FriendLocation;
        }
    }
}