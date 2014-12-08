using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConferenceMgmt.App_Code.EL;

namespace ConferenceMgmt
{
    public partial class Final : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                User objUser = (User)Session["User"];
                if (objUser.RoleID != 2)
                {
                    liRole.Visible = false;
                    liActivity.Visible = false;
                    liConference.Visible = false;
                    liTutorial.Visible = false;
                    liViewPaper.Visible = false;
                    liStatistics.Visible = false;
                }
            }
            else
            {
                Response.Redirect("default.aspx");
            }
        }
    }
}