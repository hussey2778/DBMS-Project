using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.ComponentModel;

namespace ConferenceMgmt.App_Code.DAL
{
    public class ConferenceDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        internal System.Data.DataSet GetConference(int ConferenceID = 0)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "GetConference";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ConferenceId", ConferenceID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet dataset = new DataSet();
                        da.Fill(dataset);
                        return dataset;
                    }
                }
            }
        }

        internal void DeleteConference(int ConferenceID)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "DeleteConference";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ConferenceId", ConferenceID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        internal void SaveConference(EL.Conference objConference)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "AddUpdateConference";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ConferenceId", objConference.ConferenceID);
                    cmd.Parameters.AddWithValue("@ConferenceName", objConference.ConferenceName);
                    cmd.Parameters.AddWithValue("@ConferenceDate", objConference.ConferenceDate);
                    cmd.Parameters.AddWithValue("@StartTime", objConference.StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", objConference.EndTime);
                    cmd.Parameters.AddWithValue("@ConferenceFees", objConference.ConferenceFees);                    
                    cmd.Parameters.AddWithValue("@Tutorials",string.Join(",",objConference.Tutorials));
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void SaveConferenceUser(EL.ConferenceUser objConferenceUser)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "AddConferenceUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ConferenceId", objConferenceUser.ConferenceID);
                    cmd.Parameters.AddWithValue("@UserId", objConferenceUser.UserID);
                    cmd.Parameters.AddWithValue("@Tutorials", objConferenceUser.Tutorials);
                    cmd.Parameters.AddWithValue("@Activities", objConferenceUser.Activities);
                    cmd.Parameters.AddWithValue("@Fees", objConferenceUser.Fees);
                    cmd.Parameters.AddWithValue("@FoodPreferences", objConferenceUser.FoodPreference);
                    cmd.Parameters.AddWithValue("@Comments", objConferenceUser.Comments);
                    cmd.Parameters.AddWithValue("@CreditCard", objConferenceUser.CreditCard);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal DataSet GetConferenceUser(int UserId)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = " select * from Conference c where ConferenceID not in(select ConferenceID from ConferenceUser where UserID=@UserId)";
                    cmd.CommandType = CommandType.Text;
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
    }
}