using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConferenceMgmt.App_Code.DAL;
using ConferenceMgmt.App_Code.EL;
using System.Data;

namespace ConferenceMgmt.App_Code.BL
{
    public class ConferenceBL
    {
        ConferenceDAL objConferenceDAL = new ConferenceDAL();
        public DataSet GetConference(int ConferenceId = 0)
        {
            return objConferenceDAL.GetConference(ConferenceId);
        }
        

        public void DeleteConference(int ConferenceId)
        {
            objConferenceDAL.DeleteConference(ConferenceId);
        }

        public void SaveConference(Conference objConference)
        {
            objConferenceDAL.SaveConference(objConference);
        }
        public void SaveConferenceUser(ConferenceUser objConferenceUser)
        {
            objConferenceDAL.SaveConferenceUser(objConferenceUser);
        }



        internal DataSet GetConferenceUser(int UserId)
        {
            return objConferenceDAL.GetConferenceUser(UserId);
        }
    }
}