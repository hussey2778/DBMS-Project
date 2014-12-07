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
    public partial class Adm_Paper_Dnld : System.Web.UI.Page
    {
        PaperBL objPaperBL = new PaperBL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ConferenceMgmt.App_Code.EL.Paper objPaper = new ConferenceMgmt.App_Code.EL.Paper();
            objPaper.PaperID = Convert.ToInt32(txtPaperID);
            objPaperBL.DownloadPaper(objPaper.PaperID);

        }
    }
}