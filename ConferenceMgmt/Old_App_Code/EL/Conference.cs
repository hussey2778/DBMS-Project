using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace ConferenceMgmt.App_Code.EL
{
    public class Conference
    {
        public Conference() {
            Tutorials = new List<int>();
        }
        public int ConferenceID;
        public string ConferenceName;
        public DateTime ConferenceDate;
        public string StartTime;
        public string EndTime;
        public double ConferenceFees;
        public List<int> Tutorials;
    }
}