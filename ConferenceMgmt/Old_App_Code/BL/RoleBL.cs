using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConferenceMgmt.App_Code.DAL;
using ConferenceMgmt.App_Code.EL;
using System.Data;

namespace ConferenceMgmt.App_Code.BL
{
    public class RoleBL
    {
        RoleDAL objRoleDAL = new RoleDAL();
        public DataSet GetRole(int RoleId = 0)
        {
            return objRoleDAL.GetRole(RoleId);
        }


        public void DeleteRole(int RoleId)
        {
            objRoleDAL.DeleteRole(RoleId);
        }

        public void SaveRole(Role objRole)
        {
            objRoleDAL.SaveRole(objRole);
        }
    }
}