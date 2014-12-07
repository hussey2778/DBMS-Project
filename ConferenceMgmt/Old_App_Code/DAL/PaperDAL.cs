using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ConferenceMgmt.App_Code.DAL
{
    public class PaperDAL
    {
    //    SqlConnection con;
    //    SqlCommand cmd;
    //    protected System.Data.DataSet GetPaper(int PaperId)
    //    {
    //        using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
    //        {
    //            using (cmd = new SqlCommand())
    //            {
    //                cmd.CommandText = "GetPaper";
    //                cmd.CommandType = CommandType.StoredProcedure;
    //                con.Open();
    //                cmd.Connection = con;
    //                cmd.Parameters.AddWithValue("@PaperID", PaperId);
    //                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
    //                {
    //                    DataSet dataset = new DataSet();
    //                    da.Fill(dataset);
    //                    return dataset;
    //                }
    //            }
    //        }
    //    }

    //    Protected void Accepted(String flag)
    //    {
    //        using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
    //        {
    //            using (cmd = new SqlCommand())
    //            {
    //                cmd.CommandText = "AcceptPaper";
    //                cmd.CommandType = CommandType.StoredProcedure;
    //                con.Open();
    //                cmd.Connection = con;
    //                cmd.Parameters.AddWithValue("@PaperID", flag);
    //                cmd.ExecuteNonQuery();
    //            }
    //        }
    //    }

    //    internal void Rejected(String flag)
    //    {
    //        using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
    //        {
    //            using (cmd = new SqlCommand())
    //            {
    //                cmd.CommandText = "RejectPaper";
    //                cmd.CommandType = CommandType.StoredProcedure;
    //                con.Open();
    //                cmd.Connection = con;
    //                cmd.Parameters.AddWithValue("@PaperID", flag);
    //                cmd.ExecuteNonQuery();
    //            }
    //        }
    //    }

    //    internal void DownloadPaper(int PaperID)
    //    {
    //        using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
    //        {
    //            using (cmd = new SqlCommand())
    //            {
    //                cmd.CommandText = "PaperID";
    //                cmd.CommandType = CommandType.StoredProcedure;
    //                con.Open();
    //                cmd.Connection = con;
    //                cmd.Parameters.AddWithValue("@PaperID", PaperID);
    //                cmd.ExecuteNonQuery();
    //            }
    //        }
    //    }
    //}
    }
