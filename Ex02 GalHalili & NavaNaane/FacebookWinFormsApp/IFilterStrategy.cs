using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public interface IFilterStrategy
    {
        bool ShouldFilterBirthday(string i_UserBirthday, string i_FriendBirthday);
        bool ShouldFilterHometown(City i_UserHometown, City i_FriendHometown);
        bool ShouldFilterLocation(City i_UserLocation, City i_FriendLocation);
        bool ShouldFilterGender(User.eGender? i_UserGender, User.eGender? i_FriendGender);
    }
}