using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConferenceMgmt.App_Code.BL;
using ConferenceMgmt.App_Code.EL;
using System.Data;

namespace ConferenceMgmt
{
    public partial class Signup : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RoleBL objRoleBL = new RoleBL();
                FillDropDown(ddlRole, objRoleBL.GetRole().Tables[0], "RoleName", "RoleId");
                ddlRole.Items.Remove(ddlRole.Items.FindByText("Administrator"));
            }
        }
        public void FillDropDown(DropDownList ddl, DataTable dt, string dataTextField, string dataValueField)
        {
            ddl.Items.Clear();
            ddl.Items.Add(new ListItem("--Select--", "0"));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ddl.Items.Add(new ListItem(dt.Rows[i][dataTextField].ToString(), dt.Rows[i][dataValueField].ToString()));
            }
            ddl.DataValueField = dataValueField;
            ddl.DataTextField = dataValueField;
            ddl.DataBind();
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            User objUser = new User();
            UserBL objUserBL = new UserBL();
            objUser.UserID = 0;
            objUser.FirstName = txtFirstName.Text;
            objUser.LastName = txtLastName.Text;
            objUser.Email = txtEmail.Text;
            objUser.Institution = txtInstitution.Text;
            objUser.Password = txtPassword.Text;
            objUser.RoleID = Convert.ToInt32(ddlRole.SelectedValue);
            objUserBL.SaveUser(objUser);
            objUser.Email = txtEmail.Text;
            objUser.Password = txtPassword.Text;
            if (objUserBL.ValidateLogin(objUser))
            {
                Session["User"] = objUser;
                Response.Redirect("Home.aspx");
            }
            //else
            //{
            //    lblError.Visible = true;
            //}
        }
    }
}