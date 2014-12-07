using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ConferenceMgmt.App_Code.DAL
{
    public class RoleDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        internal System.Data.DataSet GetRole(int RoleId)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "GetRole";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@RoleId", RoleId);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet dataset = new DataSet();
                        da.Fill(dataset);
                        return dataset;
                    }
                }
            }
        }

        internal void DeleteRole(int RoleId)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "DeleteRole";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@RoleId", RoleId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void SaveRole(EL.Role objRole)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "AddUpdateRole";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@RoleId", objRole.RoleID);
                    cmd.Parameters.AddWithValue("@RoleName", objRole.RoleName);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}