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
using System.Text;
namespace ConferenceMgmt
{
    public partial class Adm_Statistics : System.Web.UI.Page
    {
        ConferenceUser objConferenceUser = new ConferenceUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
                BindGrid1();
                BindGrid2();

        }
        private void BindGrid()
        {
            SqlConnection con;
            SqlCommand cmd;
            objConferenceUser.UserID = ((User)Session["User"]).UserID;
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "select cu.UserID, u.FirstName, u.LastName, c.ConferenceID, c.ConferenceName, c.ConferenceDate, c.StartTime, c.EndTime, pa.PaperID, pa.PaperName, pa.FileName, pa.PaperFees, pa.IsAccepted, p.PaymentID, p.RegistrationType, p.RegistrationTypeID, p.CreditCardNumber, cu.FoodPreferenece, cu.Comments, a.ActivityName  from Conference c join ConferenceUser cu on c.ConferenceID = cu.ConferenceID join payment p on p.UserID = cu.UserID left join ConfUserActivity cua on cua.ConfUserID = cu.ConfUserID join Activity a on cua.ActivityID = a.ActivityID join [User] u on u.UserID = cu.UserID left join Paper pa on pa.ConferenceID = c.ConferenceID";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.Connection = con;
                    //cmd.Parameters.AddWithValue("@UserID", objConferenceUser.UserID.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        grvConferencesViewStatistics.DataSource = ds.Tables[0];
                        grvConferencesViewStatistics.DataBind();
                    }
                    // lblError.Text = "";
                }
            }
        }
        private void BindGrid1()
        {
            SqlConnection con;
            SqlCommand cmd;
            objConferenceUser.UserID = ((User)Session["User"]).UserID;
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "select tu.UserID, u.FirstName, u.LastName, t.*, p.PaymentID, p.RegistrationType, p.RegistrationTypeID, p.CreditCardNumber from Tutorial t join TutorialUser tu on tu.TutorialID = t.TutorialID join payment p on p.UserID = tu.UserID join [User] u on tu.UserID = u.userID where P.RegistrationType = 'T'";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.Connection = con;
                    //cmd.Parameters.AddWithValue("@UserID", objConferenceUser.UserID.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        grvTutorialsViewStatistics.DataSource = ds.Tables[0];
                        grvTutorialsViewStatistics.DataBind();
                    }
                    // lblError.Text = "";
                }
            }
        }

        private void BindGrid2()
        {
            SqlConnection con;
            SqlCommand cmd;
            objConferenceUser.UserID = ((User)Session["User"]).UserID;
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "select p.UserID, u.FirstName, u.LastName, p.PaperID, p.FileName, p.PaperName, p.PaperFees, p.IsAccepted  from Paper p join [User] u on u.UserID = p.UserID";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.Connection = con;
                    //cmd.Parameters.AddWithValue("@UserID", objConferenceUser.UserID.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        grvPaperStatistics.DataSource = ds.Tables[0];
                        grvPaperStatistics.DataBind();
                    }
                    // lblError.Text = "";
                }
            }
        }

        protected void btnExportcsv1_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition",
             "attachment;filename=grvConferencesView.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";

            //grvConferencesViewStatistics.AllowPaging = false;
            //grvConferencesViewStatistics.DataBind();

            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < grvConferencesViewStatistics.Columns.Count; k++)
            {
                //add separator
                sb.Append(grvConferencesViewStatistics.Columns[k].HeaderText + ',');
            }
            //append new line
            sb.Append("\r\n");
            for (int i = 0; i < grvConferencesViewStatistics.Rows.Count; i++)
            {
                for (int k = 0; k < grvConferencesViewStatistics.HeaderRow.Cells.Count; k++)
                {
                    //add separator
                    sb.Append(grvConferencesViewStatistics.Rows[i].Cells[k].Text.Replace(",","") + ',');
                }
                //append new line
                sb.Append("\r\n");
            }
            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();
        }

        protected void ExportCSV2_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition",
             "attachment;filename=grvTutorialsView.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";

            //grvConferencesViewStatistics.AllowPaging = false;
            //grvConferencesViewStatistics.DataBind();

            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < grvTutorialsViewStatistics.Columns.Count; k++)
            {
                //add separator
                sb.Append(grvTutorialsViewStatistics.Columns[k].HeaderText + ',');
            }
            //append new line
            sb.Append("\r\n");
            for (int i = 0; i < grvTutorialsViewStatistics.Rows.Count; i++)
            {
                for (int k = 0; k < grvTutorialsViewStatistics.HeaderRow.Cells.Count; k++)
                {
                    //add separator
                    sb.Append(grvTutorialsViewStatistics.Rows[i].Cells[k].Text.Replace(",", "") + ',');
                }
                //append new line
                sb.Append("\r\n");
            }
            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();
        }

        protected void btnExportCSV3_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.Buffer = true;
            Response.AddHeader("content-disposition",
             "attachment;filename=grvPapersView.csv");
            Response.Charset = "";
            Response.ContentType = "application/text";

            //grvConferencesViewStatistics.AllowPaging = false;
            //grvConferencesViewStatistics.DataBind();

            StringBuilder sb = new StringBuilder();
            for (int k = 0; k < grvPaperStatistics.Columns.Count; k++)
            {
                //add separator
                sb.Append(grvPaperStatistics.Columns[k].HeaderText + ',');
            }
            //append new line
            sb.Append("\r\n");
            for (int i = 0; i < grvPaperStatistics.Rows.Count; i++)
            {
                for (int k = 0; k < grvPaperStatistics.HeaderRow.Cells.Count; k++)
                {
                    //add separator
                    sb.Append(grvPaperStatistics.Rows[i].Cells[k].Text.Replace(",", "") + ',');
                }
                //append new line
                sb.Append("\r\n");
            }
            Response.Output.Write(sb.ToString());
            Response.Flush();
            Response.End();
        }
    }

}