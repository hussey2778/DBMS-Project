using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net.Sockets;
using System.Net.Security;

namespace ConferenceMgmt
{
    public partial class Emailtest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fromAddress = "hsutt005@fiu.edu";
            string mailPassword = "27JuL1988";       // Mail id password from where mail will be sent.
            string messageBody = "Username: " + " Your Password is : test " ;
            string temp3 = "dbrah005@fiu.edu";

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
            send_mail.Subject = "Password Recovery";

            send_mail.Body = messageBody;
            client.EnableSsl = true;
            client.Send(send_mail);
           // SendEmailUsingGmail(emailId);
                  
        }
    }
}