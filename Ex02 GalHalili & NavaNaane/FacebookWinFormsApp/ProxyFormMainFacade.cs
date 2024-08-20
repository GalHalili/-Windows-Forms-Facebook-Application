using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class ProxyFormMainFacade : FacadeFormMain
    {
        public new List<Album> GetLoggedInUserAlbums()
        {
            List<Album> albumList; 

            try
            {
                albumList = SingletonFormMainLogic.Instance.GetLoggedInUserAlbums();
            }
            catch(Exception)
            {
                albumList = new List<Album>();
            }

            return albumList;
        }

        public new List<Group> GetLoggedInUserGroups()
        {
            List<Group> groupList;

            try
            {
                groupList = SingletonFormMainLogic.Instance.GetLoggedInUserGroups();
            }
            catch (Exception)
            {
                groupList = new List<Group>();
            }

            return groupList;
        }

        public new List<Event> GetLoggedInUserEvents()
        {
            List<Event> eventList;

            try
            {
                eventList = SingletonFormMainLogic.Instance.GetLoggedInUserEvents();
            }
            catch (Exception)
            {
                eventList = new List<Event>();
            }

            return eventList;
        }
    }
}