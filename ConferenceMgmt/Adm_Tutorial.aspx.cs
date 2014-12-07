using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConferenceMgmt.App_Code.BL;
using ConferenceMgmt.App_Code.DAL;
using ConferenceMgmt.App_Code.EL;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;


namespace ConferenceMgmt
{
    public partial class Adm_Tutorial : System.Web.UI.Page
    {
        TutorialBL objTutorialBL = new TutorialBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindGrid();
            
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
            Tutorial objTutorial = new Tutorial();
            objTutorial.TutorialID = Convert.ToInt32(hdnTutorialID.Value);
            objTutorial.TutorialName = txtTutorialName.Text;
            objTutorial.TutorialFees = Convert.ToDouble(txtTutorialFee.Text);
            objTutorial.StartTime = txtStartTime.Text;
            objTutorial.EndTime = txtEndTime.Text;
            objTutorial.TutorialDate = Convert.ToDateTime(txtTutorialDate.Text);
            objTutorialBL.SaveTutorial(objTutorial);
            ResetFields();
            BindGrid();

        }
        private void ResetFields()
        {
            txtTutorialName.Text = string.Empty;
            txtStartTime.Text = string.Empty;
            txtEndTime.Text = string.Empty;
            String tmp = string.Empty;
            txtTutorialDate.Text = string.Empty;
            txtTutorialFee.Text = string.Empty;
            hdnTutorialID.Value = "0";
        }
        protected void grvTutorials_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "EditTutorial")
            {
                hdnTutorialID.Value = e.CommandArgument.ToString();
                int TutorialId = Convert.ToInt32(hdnTutorialID.Value);
                DataSet ds = objTutorialBL.GetTutorial(TutorialId);
                if (ds.Tables.Count > 0)
                {
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        DataRow dr = ds.Tables[0].Rows[0];
                        txtTutorialName.Text = dr["TutorialName"].ToString();
                        txtStartTime.Text = dr["StartTime"].ToString();
                        txtEndTime.Text = dr["EndTime"].ToString();
                        String tmp = dr["TutorialDate"].ToString();
                        txtTutorialDate.Text = Convert.ToDateTime(dr["TutorialDate"].ToString()).ToString("MM/dd/yyyy");
                        txtTutorialFee.Text = dr["TutorialFees"].ToString();
                    }
                }
            }
            if (e.CommandName == "DeleteTutorial")
            {
                try
                {
                    objTutorialBL.DeleteTutorial(Convert.ToInt32(e.CommandArgument));
                    BindGrid();
                }
                catch (SqlException)
                {
                    lblError.Text = "There are existing user having this Tutorial, Cannot be deleted";
                }
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

       
        
    }
}