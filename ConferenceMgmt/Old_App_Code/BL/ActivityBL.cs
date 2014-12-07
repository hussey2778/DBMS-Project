using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConferenceMgmt.App_Code.DAL;
using ConferenceMgmt.App_Code.EL;
using System.Data;

namespace ConferenceMgmt.App_Code.BL
{
    public class ActivityBL
    {
        ActivityDAL objActivityDAL = new ActivityDAL();
        public DataSet GetActivity(int ActivityId = 0)
        {
            return objActivityDAL.GetActivity(ActivityId);
        }


        public void DeleteActivity(int ActivityId)
        {
            objActivityDAL.DeleteActivity(ActivityId);
        }

        public void SaveActivity(Activity objActivity)
        {
            objActivityDAL.SaveActivity(objActivity);
        }
    }
}