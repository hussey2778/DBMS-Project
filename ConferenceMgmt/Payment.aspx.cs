using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ConferenceMgmt.App_Code.EL;
using ConferenceMgmt.App_Code.BL;
using System.Data.SqlClient;
using System.Data;
using System.Net.Mail;
using System.IO;

namespace ConferenceMgmt
{
    public partial class Payment : System.Web.UI.Page
    {
        ConferenceUser objConferenceUser;
        TutorialUser objTutorialUser;
        Paper objPaper;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string regType = Session["RegistrationType"].ToString();
                if (regType == "Tutorial")
                {
                    objTutorialUser = (TutorialUser)Session["TutorialUser"];
                    txtFees.Text = objTutorialUser.Fees.ToString();
                }
                else if (regType == "Conference")
                {
                    objConferenceUser = (ConferenceUser)Session["ConferenceUser"];
                    txtFees.Text = objConferenceUser.Fees.ToString();
                }
                else if (regType == "Paper")
                {
                    objPaper = (Paper)Session["Paper"];
                    txtFees.Text = objPaper.PaperFees.ToString();
                }

                BindCreditCardInfo();
            }
        }

        private void BindCreditCardInfo()
        {
            using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "select * from CreditCard where UserID=@UserId";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@UserId", ((User)Session["User"]).UserID);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataSet dataset = new DataSet();
                        da.Fill(dataset);
                        if (dataset.Tables.Count > 0 && dataset.Tables[0].Rows.Count > 0)
                        {
                            DataRow dr = dataset.Tables[0].Rows[0];
                            txtCardHolderName.Text = dr["CardHolderName"].ToString();
                            txtCardNo.Text = dr["CreditCardNo"].ToString();
                            txtExpDateMM.Text = dr["ExpirationMonth"].ToString();
                            txtExpDateYYYY.Text = dr["ExpirationYear"].ToString();
                            txtSecurirtyCode.Text = dr["SecurityCode"].ToString();
                        }
                    }
                }
            }
        }
        private void RegisterForConference()
        {
            ConferenceUser objConferenceUser = (ConferenceUser)Session["ConferenceUser"];
            objConferenceUser.CreditCard = txtCardNo.Text;
            ConferenceBL objConferenceBL = new ConferenceBL();
            objConferenceBL.SaveConferenceUser(objConferenceUser);
            SendReceipt();
            Response.Redirect("View_Conference.aspx");
        }
        private void RegisterForTutorial()
        {
            TutorialUser objTutorialUser = (TutorialUser)Session["TutorialUser"];
            objTutorialUser.CreditCard = txtCardNo.Text;
            TutorialBL objTutorialBL = new TutorialBL();
            objTutorialBL.SaveTutorialUser(objTutorialUser);
            SendReceipt();
            Response.Redirect("View_Tutorial.aspx");
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveCreditCard();
            string regType = Session["RegistrationType"].ToString();
            if (regType == "Tutorial")
            {
                RegisterForTutorial();
            }
            else if (regType == "Conference")
            {
                RegisterForConference();
            }
            else if (regType == "Paper")
            {
                SubmitPaper();
            }


        }

        private void SubmitPaper()
        {
            objPaper = (Paper)Session["Paper"];
            string path = Server.MapPath("~/");
            String savePath = path + "/Uploads/";
            savePath = savePath + objPaper.FileName;

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

                using (var sqlWrite = new SqlCommand("INSERT INTO Payment (UserId,RegistrationType,CreditCardNumber,RegistrationTypeId)Values(" + objPaper.UserID + ",'P'," + txtCardNo.Text + ",'" + objPaper.PaperID + "')", varConnection))
                {                    
                    sqlWrite.ExecuteNonQuery();
                  
                }
                using (var sqlWrite = new SqlCommand("INSERT INTO Paper (UserID,ConferenceID,FileName,PaperName,PaperFees,Data)Values(" + objPaper.UserID + "," + objPaper.ConfereneceId + ",'" + objPaper.FileName + "','" + objPaper.PaperName + "'," + objPaper.PaperFees + ",@File)", varConnection))
                {
                    sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                    sqlWrite.ExecuteNonQuery();
                    File.Delete(savePath);
                    Response.Redirect("View_Paper.aspx");
                }
            }
        }

        private void SaveCreditCard()
        {
            if (cbSaveCard.Checked)
            {
                CreditCard objCreditCard = new CreditCard();
                objCreditCard.CardHolderName = txtCardHolderName.Text;
                objCreditCard.CreditCardNo = txtCardNo.Text;
                objCreditCard.ExpirationMonth = Convert.ToInt32(txtExpDateMM.Text);
                objCreditCard.ExpirationYear = Convert.ToInt32(txtExpDateYYYY.Text);
                objCreditCard.SecurityCode = Convert.ToInt32(txtSecurirtyCode.Text);

                using (SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = @"INSERT INTO [dbo].[CreditCard]([CreditCardNo],[CardHolderName],[ExpirationMonth],[ExpirationYear],[SecurityCode],[UserID])
                                            VALUES (@CreditCardNo,@CardHolderName,@ExpirationMonth,@ExpirationYear,@SecurityCode,@UserId)";
                        cmd.CommandType = CommandType.Text;
                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@CreditCardNo", objCreditCard.CardHolderName);
                        cmd.Parameters.AddWithValue("@CardHolderName", objCreditCard.CreditCardNo);
                        cmd.Parameters.AddWithValue("@ExpirationMonth", objCreditCard.ExpirationMonth);
                        cmd.Parameters.AddWithValue("@ExpirationYear", objCreditCard.ExpirationYear);
                        cmd.Parameters.AddWithValue("@SecurityCode", objCreditCard.SecurityCode);
                        cmd.Parameters.AddWithValue("@UserId", ((User)Session["User"]).UserID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void SendReceipt()
        {

            User objUser = (User)Session["User"];
            string from = "team9crs@gmail.com";
            string pwd = "nineteam9";       // Mail id password from where mail will be sent.
            string regType = Session["RegistrationType"].ToString();
            string body = string.Empty;
            if (regType == "Tutorial")
            {
                objTutorialUser = (TutorialUser)Session["TutorialUser"];
                body = @"<h1>Congratulations<h1><br/>" +
                                   "<h3>Your registration is Cofirmed<h3><br/>" +
                                   "Fees Paid : " + objTutorialUser.Fees.ToString() + "<br/>" +
                                   "<b>Thank you for using Team 9 Conference Registration System</b>";

            }
            else if (regType == "Conference")
            {
                objConferenceUser = (ConferenceUser)Session["ConferenceUser"];
                body = @"<h1>Congratulations<h1><br/>" +
                                    "<h3>Your registration is Cofirmed<h3><br/>" +
                                    "Conference : " + objConferenceUser.ConferenceName + "<br/>" +
                                    "Fees Paid : " + objConferenceUser.Fees.ToString() + "<br/>" +
                                    "<b>Thank you for using Team 9 Conference Registration System</b>";

            }
            else if (regType == "Paper")
            {
                objPaper = (Paper)Session["Paper"];
                body = @"<h1>Congratulations<h1><br/>" +
                                      "<h3>Your paper is submitted<h3><br/>" +
                                      "Conference : " + objPaper.PaperName + "<br/>" +
                                      "Fees Paid : " + objPaper.PaperFees.ToString() + "<br/>" +
                                      "<b>Thank you for using Team 9 Conference Registration System</b>";
            }



            string to = objUser.Email;

            // Create smtp connection.
            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;//outgoing port for the mail.
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Timeout = 10000;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new System.Net.NetworkCredential(from, pwd);


            MailMessage mail = new MailMessage();
            mail.IsBodyHtml = true;
            mail.From = new MailAddress(from);
            mail.To.Add(new MailAddress(to));
            mail.Subject = "Payment Confirmation";
            mail.Body = body;
            smtpClient.EnableSsl = true;
            smtpClient.Send(mail);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}