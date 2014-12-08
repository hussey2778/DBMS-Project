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
    public partial class TutorialRegistration : System.Web.UI.Page
    {
        ConferenceBL objConferenceBL = new ConferenceBL();
        TutorialBL objTutorialBL = new TutorialBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grvTutorials.DataSource = objTutorialBL.GetTutorial().Tables[0];
                grvTutorials.DataBind();
            }
        }        

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder tutorialIDs = new StringBuilder("");
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
            if (tutorials.Length > 0)
            {
                TutorialUser objTutorialUser = new TutorialUser();
                Session["RegistrationType"] = "Tutorial";
                objTutorialUser.UserID = ((User)Session["User"]).UserID;
                objTutorialUser.Tutorials = tutorials;
                objTutorialUser.Fees = Convert.ToDouble(txtTotalFees.Text);
                Session["TutorialUser"] = objTutorialUser;
                Response.Redirect("Payment.aspx");
            }
            else
                lblError.Text = "Please select at least one tutorial";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Tutorial.aspx");
        }       

    }
}