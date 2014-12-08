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
            if (!IsPostBack)
            {
                Common.FillDropDown(ddlConference, new ConferenceBL().GetConference().Tables[0], "ConferenceName", "ConferenceID");
            }
        }
        
        protected void btnSave_Click(object sender, EventArgs e)
        {
            string path = Server.MapPath("~/");
            String savePath = path + "/Uploads/";
            System.IO.Directory.CreateDirectory(savePath);
            savePath = savePath + fuPaper.FileName;
            fuPaper.SaveAs(savePath);

            Paper objPaper = new Paper();
            objPaper.UserID = ((User)Session["User"]).UserID;
            objPaper.ConfereneceId =Convert.ToInt32(ddlConference.SelectedValue);
            objPaper.PaperName = txtPaper.Text;
            objPaper.PaperFees = Convert.ToDouble(lblFees.Text);
            objPaper.FileName = fuPaper.FileName;
            Session["RegistrationType"] = "Paper";
            Session["Paper"] = objPaper;

            Response.Redirect("Payment.aspx");
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("View_Paper.aspx");
        }
    }
}