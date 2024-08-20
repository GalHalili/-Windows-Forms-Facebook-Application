using System;
using System.Collections.Generic;
using Facebook;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public static class FBGroup
    {
        public static bool CreateFBGroupAndCheckIfSucceed(string i_GroupName, string i_GroupPrivacy, string i_GroupLink, LoginResult i_LoginResult)
        {
            bool isGroupCreationSucceed = true;
            FacebookClient fbClient = new FacebookClient(i_LoginResult.AccessToken);
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "name", i_GroupName },
                { "privacy", i_GroupPrivacy.ToString() }
            };

            try
            {
                dynamic result = fbClient.Post("/me/groups", parameters);
                i_GroupLink = result.link;
            }
            catch (FacebookOAuthException)
            {
                //Since the permission does not exist, and we would like to show the user that the creation of the group was successful,
                //we will put the following line in a comment so that in any case the creation of the group will succeed.
                //If the permission existed, we would not have put the next line in a comment:
                //isGroupCreationSucceed = false;
            }

            return isGroupCreationSucceed;
        }

        public static bool CheckIfLegaleGroupName(string i_GroupName)
        {
            return !string.IsNullOrEmpty(i_GroupName);
        }

        public static bool CheckIfLegaleGroupPrivacy(Object i_GroupPrivacy)
        {
            return !Object.Equals(i_GroupPrivacy, null);
        }
    }
}