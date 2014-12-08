using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ConferenceMgmt.App_Code.DAL;
using ConferenceMgmt.App_Code.EL;
using System.Data;

namespace ConferenceMgmt.App_Code.BL
{
    public class TutorialBL
    {
        TutorialDAL objTutorialDAL = new TutorialDAL();
        public DataSet GetTutorial(int TutorialId = 0)
        {
            return objTutorialDAL.GetTutorial(TutorialId);
        }


        public void DeleteTutorial(int TutorialId)
        {
            objTutorialDAL.DeleteTutorial(TutorialId);
        }

        public void SaveTutorial(Tutorial objTutorial)
        {
            objTutorialDAL.SaveTutorial(objTutorial);
        }
    }
}