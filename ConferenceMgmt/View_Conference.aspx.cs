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
    public partial class View_Conference : System.Web.UI.Page
    {
        ConferenceUser objConferenceUser = new ConferenceUser();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();

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
                    cmd.CommandText = "select c.* from dbo.Conference c join ConferenceUser cu on c.ConferenceID=cu.ConferenceID where cu.UserID=@UserID";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@UserID", objConferenceUser.UserID.ToString());
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        grvConferencesView.DataSource = ds.Tables[0];
                        grvConferencesView.DataBind();
                    }
                    // lblError.Text = "";
                }
            }
        }
    }
}