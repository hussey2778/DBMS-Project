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

namespace ConferenceMgmt
{
    public partial class Payment : System.Web.UI.Page
    {
        ConferenceUser objConferenceUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objConferenceUser = (ConferenceUser)Session["ConferenceUser"];
                txtFees.Text = objConferenceUser.Fees.ToString();
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
                    cmd.Parameters.AddWithValue("@UserId", objConferenceUser.UserID);
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
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ConferenceUser objConferenceUser = (ConferenceUser)Session["ConferenceUser"];
            objConferenceUser.CreditCard = txtCardNo.Text;
            ConferenceBL objConferenceBL = new ConferenceBL();
            objConferenceBL.SaveConferenceUser(objConferenceUser);
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
                        cmd.Parameters.AddWithValue("@UserId", objConferenceUser.UserID);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            SendReceipt();
            Response.Redirect("View_Conference.aspx");

        }

        private void SendReceipt()
        {
            objConferenceUser = (ConferenceUser)Session["ConferenceUser"];
            User objUser = (User)Session["User"];
            string fromAddress = "team9crs@gmail.com";
            string mailPassword = "nineteam9";       // Mail id password from where mail will be sent.
            string messageBody = @"<h1>Congratulations<h1><br/>" +
                                   "<h3>Your registration is Cofirmed<h3><br/>" +
                                   "Conference : " + objConferenceUser.ConferenceName + "<br/>" +
                                   "Fees Paid : " + objConferenceUser.Fees.ToString() + "<br/>" +
                                   "<b>Thank you for using Team 9 Conference Registration System</b>";


            string temp3 = objUser.Email;

            // Create smtp connection.
            SmtpClient client = new SmtpClient();
            client.Port = 587;//outgoing port for the mail.
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(fromAddress, mailPassword);


            // Fill the mail form.
            MailMessage send_mail = new MailMessage();

            send_mail.IsBodyHtml = true;
            //address from where mail will be sent.
            send_mail.From = new MailAddress(fromAddress);
            //address to which mail will be sent.           
            send_mail.To.Add(new MailAddress(temp3));
            //subject of the mail.
            send_mail.Subject = "Payment Confirmation";

            send_mail.Body = messageBody;
            client.EnableSsl = true;
            client.Send(send_mail);
        }
    }
}