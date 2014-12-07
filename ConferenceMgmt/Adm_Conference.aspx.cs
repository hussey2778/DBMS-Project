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
    public partial class Adm_Conference : System.Web.UI.Page
    {

        ConferenceBL objConferenceBL = new ConferenceBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
                TutorialBL objTutorialBL = new TutorialBL();
                BindList(lstTutorials, objTutorialBL.GetTutorial().Tables[0], "TutorialName", "TutorialID");
            }
        }
        
        public void BindList(ListBox lst, DataTable dt, string dataTextField, string dataValueField)
        {
            lst.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                lst.Items.Add(new ListItem(dt.Rows[i][dataTextField].ToString(), dt.Rows[i][dataValueField].ToString()));
            }
            lst.DataValueField = dataValueField;
            lst.DataTextField = dataValueField;
            lst.DataBind();
        }
        private void BindGrid()
        {
            DataSet ds = objConferenceBL.GetConference();
            if (ds.Tables.Count > 0)
            {
                grvConferences.DataSource = ds.Tables[0];
                grvConferences.DataBind();
            }
            lblError.Text = "";
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Conference objConference = new Conference();
            objConference.ConferenceID = Convert.ToInt32(hdnConferenceID.Value);
            objConference.ConferenceName = txtConferenceName.Text;
            objConference.ConferenceFees = Convert.ToDouble(txtConferenceFee.Text);
            objConference.StartTime = txtStartTime.Text;
            objConference.EndTime = txtEndTime.Text;
            objConference.ConferenceDate = Convert.ToDateTime(txtConferenceDate.Text);
            foreach (ListItem l in lstTutorials.Items)
            {
                if (l.Selected)
                    objConference.Tutorials.Add(Convert.ToInt32(l.Value));
            }
            objConferenceBL.SaveConference(objConference);
            ResetFields();
            BindGrid();

        }
        private void ResetFields()
        {
            txtConferenceName.Text = string.Empty;
            txtStartTime.Text = string.Empty;
            txtEndTime.Text = string.Empty;
            String tmp = string.Empty;
            txtConferenceDate.Text = string.Empty;
            txtConferenceFee.Text = string.Empty;
            hdnConferenceID.Value = "0";
            lstTutorials.ClearSelection();
        }
        protected void grvConferences_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            ResetFields();
            if (e.CommandName == "EditConference")
            {                
                hdnConferenceID.Value = e.CommandArgument.ToString();
                int ConferenceId = Convert.ToInt32(hdnConferenceID.Value);
                DataSet ds = objConferenceBL.GetConference(ConferenceId);
                if (ds.Tables.Count > 1)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        txtConferenceName.Text = dr["ConferenceName"].ToString();
                        txtStartTime.Text = dr["StartTime"].ToString();
                        txtEndTime.Text = dr["EndTime"].ToString();
                        String tmp = dr["ConferenceDate"].ToString();
                        txtConferenceDate.Text = Convert.ToDateTime(dr["ConferenceDate"].ToString()).ToString("MM/dd/yyyy");
                        txtConferenceFee.Text = dr["ConferenceFees"].ToString();
                    }
                    foreach (DataRow dr in ds.Tables[1].Rows)
                    {
                        lstTutorials.Items.FindByValue(dr["TutorialID"].ToString()).Selected=true;
                    }

                }
            }
            if (e.CommandName == "DeleteConference")
            {
                try
                {
                    objConferenceBL.DeleteConference(Convert.ToInt32(e.CommandArgument));
                    BindGrid();
                }
                catch (SqlException)
                {
                    lblError.Text = "There are existing user having this Conference, Cannot be deleted";
                }
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields();
        }
    }
}