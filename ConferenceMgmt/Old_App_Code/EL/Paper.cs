using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConferenceMgmt.App_Code.EL
{
    public class Paper
    {
        public int PaperID;
        public int UserID;
        public string PaperName;
        public double PaperFees;
        public bool IsAccepted;
        public int ConfereneceId;
        public string FileName;
    }
}