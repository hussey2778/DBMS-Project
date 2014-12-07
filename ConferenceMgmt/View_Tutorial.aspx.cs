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
    public partial class View_Tutorial : System.Web.UI.Page
    {

        TutorialUser objTutorialUser = new TutorialUser();


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();
        }

        private void BindGrid()
        {
            SqlConnection con;
            SqlCommand cmd;
            objTutorialUser.UserID = ((User)Session["User"]).UserID;
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    // Template for tutorial query from ConferenceUser
                    //cmd.CommandText = "select c.* from dbo.Conference c join ConferenceUser cu on c.ConferenceID=cu.ConferenceID where cu.UserID=@UserID";
                    cmd.CommandText = "select t.* from dbo.Tutorial t join TutorialUser tu on t.TutorialID = tu.TutorialID where tu.UserID=@UserID";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.Connection = con;
                    //cmd.Parameters.AddWithValue("@UserID", objConferenceUser.UserID.ToString());
                    cmd.Parameters.AddWithValue("@UserID", objTutorialUser.UserID.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        grvTutorialsView.DataSource = ds.Tables[0];
                        grvTutorialsView.DataBind();
                    }
                    // lblError.Text = "";
                }
            }
        }

    }
}