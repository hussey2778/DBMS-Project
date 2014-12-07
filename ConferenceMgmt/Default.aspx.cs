using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConferenceMgmt.App_Code.BL;
using ConferenceMgmt.App_Code.EL;

namespace ConferenceMgmt
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            User objUser = new User();
            UserBL objUserBL = new UserBL();
            objUser.UserID = 0;           
            objUser.Email = txtEmail.Text;
            objUser.Password = txtPassword.Text;
            if (objUserBL.ValidateLogin(objUser))
            {
                Session["User"] = objUser;
                Response.Redirect("Home.aspx");                
            }
            else
            {
                lblError.Visible = true;
            }
        }
    }
}