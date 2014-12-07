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
    public partial class index_tutorial_registration : System.Web.UI.Page
    {
        TutorialBL objTutorialBL = new TutorialBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
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
            //lblError.Text = "";
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

            //foreach (ListItem l in lstActivities.Items)
            //{
            //    if (l.Selected)
            //    {
            //        tutorialIDs.Append(l.Value);
            //        tutorialIDs.Append(",");
            //    }
            //}
            string activities = activityIDs.ToString().Trim(charsToTrim);
            ConferenceUser objConferenceUser = new ConferenceUser();
            objConferenceUser.Tutorials = tutorials;
            //objConferenceUser.Activities = activities;
            objConferenceUser.Comments = txtComments.Text;
            objConferenceUser.Fees = Convert.ToDouble(txtTotalFees.Text);
            Session["ConferenceUser"] = objConferenceUser;
            Response.Redirect("Payment.aspx");

        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }

    }
}