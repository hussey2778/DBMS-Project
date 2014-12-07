using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConferenceMgmt.App_Code.BL;
using ConferenceMgmt.App_Code.EL;
using System.Data;
using System.Data.SqlClient;

namespace ConferenceMgmt
{
    public partial class Roles : System.Web.UI.Page
    {
        RoleBL objRoleBL = new RoleBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        protected void grvRoles_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditRole")
            {                
                hdnRoleId.Value = e.CommandArgument.ToString();
                int RoleId = Convert.ToInt32(hdnRoleId.Value);                
                DataSet ds = objRoleBL.GetRole(RoleId);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        txtRole.Text = dr["RoleName"].ToString();
                    }
                }
            }
            if (e.CommandName == "DeleteRole")
            {
                try
                {
                    objRoleBL.DeleteRole(Convert.ToInt32(e.CommandArgument));
                    BindGrid();
                }
                catch (SqlException)
                {
                    lblError.Text = "There are existing user having this Role, Cannot be deleted";
                }
            }
        }
        
        private void BindGrid()
        {
            DataSet ds = objRoleBL.GetRole();
            if (ds.Tables.Count > 0)
            {
                grvRoles.DataSource = ds.Tables[0];
                grvRoles.DataBind();
            }
            lblError.Text = "";
        }
   
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Role objRole = new Role();
            objRole.RoleID = Convert.ToInt32(hdnRoleId.Value);
            objRole.RoleName = txtRole.Text;
            objRoleBL.SaveRole(objRole);
            txtRole.Text = string.Empty;
            hdnRoleId.Value = "0";
            BindGrid();
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtRole.Text = string.Empty;
            hdnRoleId.Value = "0";
        }       
    }
}