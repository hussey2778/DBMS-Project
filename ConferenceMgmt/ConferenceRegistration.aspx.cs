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
using System.Text;

namespace ConferenceMgmt
{
    public partial class ConferenceRegistration : System.Web.UI.Page
    {
        ConferenceBL objConferenceBL = new ConferenceBL();
        TutorialBL objTutorialBL = new TutorialBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindFields();
            }
        }

        private void BindFields()
        {
            DataTable dt = objConferenceBL.GetConferenceUser(((User)Session["User"]).UserID).Tables[0];
            Common.FillDropDown(ddlCoferenceName, dt, "ConferenceName", "ConferenceID");
            ddlCoferenceName.Items.Remove(ddlCoferenceName.Items.FindByValue("0"));
            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];
                SetConferenceFields(Convert.ToInt32(dr["ConferenceID"].ToString()));
            }
        }
        private void SetConferenceFields(int conferenceId)
        {
            ActivityBL objActivityBL=new ActivityBL();
            DataSet ds = objConferenceBL.GetConference(conferenceId);
            DataTable dtConference = ds.Tables[0];
            DataTable dtTutorials = ds.Tables[1];
            DataRow dr = dtConference.Rows[0];
            Common.BindList(lstActivities, objActivityBL.GetActivity().Tables[0], "ActivityName", "ActivityID");
            lblConferenceDate.Text = Convert.ToDateTime(dr["ConferenceDate"].ToString()).ToString("MM/dd/yyyy");
            lblStartTime.Text = dr["StartTime"].ToString();
            lblEndTime.Text = dr["EndTime"].ToString();
            lblConferenceFees.Text = dr["ConferenceFees"].ToString();
            txtTotalFees.Text = dr["ConferenceFees"].ToString();
            if (dtTutorials.Rows.Count > 0)
            {
                lblNoTutorial.Visible = false;
                grvTutorials.Visible = true;
                grvTutorials.DataSource = dtTutorials;
                grvTutorials.DataBind();
            }
            else
            {
                grvTutorials.Visible = false;
                lblNoTutorial.Visible = true;
            }
        }
        private void BindGrid()
        {
            DataSet ds = objTutorialBL.GetTutorial();
            if (ds.Tables.Count > 0)
            {
                grvTutorials.DataSource = ds.Tables[0];
                grvTutorials.DataBind();
            }
            lblError.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder tutorialIDs = new StringBuilder("");
            StringBuilder activityIDs = new StringBuilder("");
            foreach (GridViewRow gr in grvTutorials.Rows)
            {
                if (((CheckBox)(gr.FindControl("cbSelectTutorial"))).Checked)
                {
                    tutorialIDs.Append(grvTutorials.DataKeys[gr.RowIndex].Value.ToString());
                    tutorialIDs.Append(",");
                }
            }
            char[] charsToTrim = { ',' };
            string tutorials = tutorialIDs.ToString().Trim(charsToTrim);

            foreach (ListItem l in lstActivities.Items)
            {
                if (l.Selected)
                {
                    activityIDs.Append(l.Value);
                    activityIDs.Append(",");
                }
            }            
            string activities = activityIDs.ToString().Trim(charsToTrim);
            ConferenceUser objConferenceUser = new ConferenceUser();
            objConferenceUser.ConferenceName = ddlCoferenceName.SelectedItem.Text;
            objConferenceUser.UserID = ((User)Session["User"]).UserID;
            objConferenceUser.ConferenceID = Convert.ToInt32(ddlCoferenceName.SelectedValue);
            objConferenceUser.Tutorials = tutorials;
            objConferenceUser.Activities = activities;
            objConferenceUser.Comments = txtComments.Text;
            objConferenceUser.Fees = Convert.ToDouble(txtTotalFees.Text);
            objConferenceUser.FoodPreference = ddlFoodPreferences.SelectedItem.Text;
            Session["ConferenceUser"] = objConferenceUser;
            Response.Redirect("Payment.aspx");

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        protected void ddlCoferenceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetConferenceFields(Convert.ToInt32(ddlCoferenceName.SelectedValue));
        }

    }
}