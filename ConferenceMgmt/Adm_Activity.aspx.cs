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
    public partial class Adm_Activity : System.Web.UI.Page
    {
        
        ActivityBL objActivityBL = new ActivityBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
        }
        protected void grvActivities_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditActivity")
            {                
                hdnActivityId.Value = e.CommandArgument.ToString();
                int ActivityId = Convert.ToInt32(hdnActivityId.Value);                
                DataSet ds = objActivityBL.GetActivity(ActivityId);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        txtActivity.Text = dr["ActivityName"].ToString();
                    }
                }
            }
            if (e.CommandName == "DeleteActivity")
            {
                try
                {
                    objActivityBL.DeleteActivity(Convert.ToInt32(e.CommandArgument));
                    BindGrid();
                }
                catch (SqlException)
                {
                    lblError.Text = "There are existing user having this Activity, Cannot be deleted";
                }
            }
        }
        
        private void BindGrid()
        {
            DataSet ds = objActivityBL.GetActivity();
            if (ds.Tables.Count > 0)
            {
                grvActivities.DataSource = ds.Tables[0];
                grvActivities.DataBind();
            }
            lblError.Text = "";
        }
   
        protected void btnSave_Click(object sender, EventArgs e)
        {
            Activity objActivity = new Activity();
            objActivity.ActivityID = Convert.ToInt32(hdnActivityId.Value);
            objActivity.ActivityName = txtActivity.Text;
            objActivityBL.SaveActivity(objActivity);
            txtActivity.Text = string.Empty;
            hdnActivityId.Value = "0";
            BindGrid();
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtActivity.Text = string.Empty;
            hdnActivityId.Value = "0";
        }

        protected void hdnConferenceID_ValueChanged(object sender, EventArgs e)
        {

        }       
    }
}