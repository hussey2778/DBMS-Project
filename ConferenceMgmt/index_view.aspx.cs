using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConferenceMgmt.App_Code.EL;

namespace ConferenceMgmt
{
    public partial class index_view : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User objUser=(User)Session["User"];
            lblEmail.Text = objUser.Email;
            lblInstitution.Text = objUser.Institution;
            lblName.Text = objUser.FirstName + " " + objUser.LastName;

        }
    }
}