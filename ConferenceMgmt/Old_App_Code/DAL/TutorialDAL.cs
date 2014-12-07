using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace ConferenceMgmt.App_Code.DAL
{
    public class TutorialDAL
    {
        SqlConnection con;
        SqlCommand cmd;
        internal System.Data.DataSet GetTutorial(int TutorialID=0)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "GetTutorial";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@TutorialId", TutorialID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet dataset = new DataSet();
                        da.Fill(dataset);
                        return dataset;
                    }
                }
            }
        }

        internal void DeleteTutorial(int TutorialID)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "DeleteTutorial";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@TutorialId", TutorialID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        internal void SaveTutorial(EL.Tutorial objTutorial)
        {
            using (con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (cmd = new SqlCommand())
                {
                    cmd.CommandText = "AddUpdateTutorial";
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@TutorialId", objTutorial.TutorialID);
                    cmd.Parameters.AddWithValue("@TutorialName", objTutorial.TutorialName);
                    cmd.Parameters.AddWithValue("@TutorialDate", objTutorial.TutorialDate);
                    cmd.Parameters.AddWithValue("@StartTime", objTutorial.StartTime);
                    cmd.Parameters.AddWithValue("@EndTime", objTutorial.EndTime);
                    cmd.Parameters.AddWithValue("@TutorialFees", objTutorial.TutorialFees);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}