using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ConferenceMgmt.App_Code.DAL
{
    public class ActivityDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        public System.Data.DataSet GetActivity(int ActivityId)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "GetActivity";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ActivityId", ActivityId);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet dataset = new DataSet();
                        da.Fill(dataset);
                        return dataset;
                    }
                }
            }
        }

        public void DeleteActivity(int ActivityId)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "DeleteActivity";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ActivityId", ActivityId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void SaveActivity(EL.Activity objActivity)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "AddUpdateActivity";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ActivityId", objActivity.ActivityID);
                    cmd.Parameters.AddWithValue("@ActivityName", objActivity.ActivityName);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}