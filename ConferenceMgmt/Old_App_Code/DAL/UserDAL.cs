using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ConferenceMgmt.App_Code.DAL
{
    public class UserDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        internal System.Data.DataSet GetUser(int UserId)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "GetUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet dataset = new DataSet();
                        da.Fill(dataset);
                        return dataset;
                    }
                }
            }
        }

        internal void DeleteUser(int UserId)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "DeleteUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@UserId", UserId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void SaveUser(EL.User objUser)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "AddUpdateUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@UserId", objUser.UserID);
                    cmd.Parameters.AddWithValue("@FirstName", objUser.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", objUser.LastName);
                    cmd.Parameters.AddWithValue("@Password", objUser.Password);
                    cmd.Parameters.AddWithValue("@Institution", objUser.Institution);
                    cmd.Parameters.AddWithValue("@Email", objUser.Email);
                    cmd.Parameters.AddWithValue("@RoleId", objUser.RoleID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool ValidateLogin(EL.User objUser)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "ValidateLogin";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@Email", objUser.Email);
                    cmd.Parameters.AddWithValue("@Password", objUser.Password);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        if (ds.Tables.Count > 0 && ds.Tables[0].Columns.Count > 1)
                        {
                            DataRow dr = ds.Tables[0].Rows[0];
                            objUser.FirstName = dr["FirstName"].ToString();
                            objUser.LastName = dr["LastName"].ToString();
                            objUser.Institution = dr["Institution"].ToString();
                            objUser.Email = dr["Email"].ToString();
                            objUser.RoleID = Convert.ToInt32(dr["RoleID"].ToString());
                            objUser.UserID = Convert.ToInt32(dr["UserID"].ToString());
                            return true;
                        }
                        return false;
                    }
                }
            }
        }
    }
}