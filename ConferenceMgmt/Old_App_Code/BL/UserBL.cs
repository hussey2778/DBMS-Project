using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConferenceMgmt.App_Code.DAL;
using ConferenceMgmt.App_Code.EL;
using System.Data;

namespace ConferenceMgmt.App_Code.BL
{
    public class UserBL
    {
        UserDAL objUserDAL = new UserDAL();
        public DataSet GetUser(int UserId = 0)
        {
            return objUserDAL.GetUser(UserId);
        }


        public void DeleteUser(int UserId)
        {
            objUserDAL.DeleteUser(UserId);
        }

        public void SaveUser(User objUser)
        {
            objUserDAL.SaveUser(objUser);
        }

        public bool ValidateLogin(User objUser)
        {
            return objUserDAL.ValidateLogin(objUser);
        }
    }
}