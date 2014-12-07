using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConferenceMgmt.App_Code.BL;
using ConferenceMgmt.App_Code.EL;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ConferenceMgmt
{
    public partial class PaperSubmission : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("/");
            String savePath = path + "/Uploads/";
            System.IO.Directory.CreateDirectory(savePath);
            savePath = savePath + fuPaper.FileName;
            fuPaper.SaveAs(savePath);


            byte[] file;

            using (var stream = new FileStream(savePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                }
            }
            using (var varConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                varConnection.Open();
                User objUser = (User)Session["User"];

                using (var sqlWrite = new SqlCommand("INSERT INTO Paper (UserID,FileName,PaperName,PaperFees,Data)Values(" + objUser.UserID + ",'" + fuPaper.FileName + "','" + txtPaper.Text + "',50,@File)", varConnection))
                {
                    sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                    sqlWrite.ExecuteNonQuery();
                }
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtPaper.Text = string.Empty;
            hdnPaperId.Value = "0";
        }
    }
}