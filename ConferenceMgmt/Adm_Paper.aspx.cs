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
    public partial class Adm_Paper : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                BindGrid();

        }

        private void BindGrid()
        {
            SqlConnection con;
            SqlCommand cmd;
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "select * from dbo.Paper";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.Connection = con;
                    //com.Parameters.AddWithValue("id", grvPaper.SelectedRow.Cells[1].Text);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    if (ds.Tables.Count > 0)
                    {
                        grvPaper.DataSource = ds.Tables[0];
                        grvPaper.DataBind();
                    }
                    // lblError.Text = "";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StringBuilder PaperIDs = new StringBuilder("");
            foreach (GridViewRow gr in grvPaper.Rows)
            {
                if (((CheckBox)(gr.FindControl("cbSelectPaper"))).Checked)
                {
                    PaperIDs.Append(grvPaper.DataKeys[gr.RowIndex].Value.ToString());
                    PaperIDs.Append(",");
                }
            }
            char[] charsToTrim = { ',' };
            string PaperID = PaperIDs.ToString().Trim(charsToTrim);
            SqlConnection con;
            SqlCommand com;
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                con.Open();
                string query;
                query = "Update Paper set IsAccepted=1 where PaperID in (select value from fn_split(@PaperID,','))";   //insert query
                com = new SqlCommand(query, con);
                com.Parameters.Add("@PaperID", SqlDbType.VarChar).Value = PaperID;
                com.ExecuteNonQuery();

                //objPaperBL.Accepted(PaperID);
            }
        }

        protected void txtAccepted_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            StringBuilder PaperIDs = new StringBuilder("");
            foreach (GridViewRow gr in grvPaper.Rows)
            {
                if (((CheckBox)(gr.FindControl("cbSelectPaper"))).Checked)
                {
                    PaperIDs.Append(grvPaper.DataKeys[gr.RowIndex].Value.ToString());
                    PaperIDs.Append(",");
                }
            }
            char[] charsToTrim = { ',' };
            string PaperID = PaperIDs.ToString().Trim(charsToTrim);
            SqlConnection con;
            SqlCommand com;
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                con.Open();
                string query;
                query = "Update Paper set IsAccepted=0 where PaperID in (select value from fn_split(@PaperID,','))";   //insert query
                com = new SqlCommand(query, con);
                com.Parameters.Add("@PaperID", SqlDbType.VarChar).Value = PaperID;
                com.ExecuteNonQuery();
            }
        }


        protected void grvPaper_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "DownloadPaper")
            {
                SqlConnection con;
                using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {
                    con.Open();
                    SqlCommand com = new SqlCommand("select * from Paper where PaperID=" + e.CommandArgument.ToString(), con);
                    SqlDataReader dr = com.ExecuteReader();
                    if (dr.Read())
                    {
                        Response.Clear();
                        Response.Buffer = true;
                        //Response.ContentType = dr["type"].ToString();

                        Response.AddHeader("content-disposition", "attachment;filename=\"" + dr["FileName"].ToString() + "\"");     // to open file prompt Box open or Save file         
                        Response.Charset = "";
                        Response.Cache.SetCacheability(HttpCacheability.NoCache);
                        Response.BinaryWrite((byte[])dr["Data"]);
                        Response.End();

                    }
                }

            }

        }


    }
}
