using System.Net.Mail;
using System.Web.Http;

namespace BlaineSmith.Business
{
    public class EmailManager
    {
        public MailMessage Msg;
        public SmtpClient Client;

        public EmailManager()
        {
            Msg = new MailMessage();
            Client = new SmtpClient();
        }

        public void SendEmail([FromBody] MessageContent content)
        {
            const string userName = "blaine@blainesmith.net";
            const string passw = "Broncos1!";
            const string toEmail = "blaine@blainesmith.net";
            const string toName = "Blaine Smith";

            Msg.To.Add(new MailAddress(toEmail, toName));
            Msg.From = new MailAddress(content.From, content.FromName);
            Msg.Subject = content.Subject;
            Msg.Body = content.Body;
            Msg.IsBodyHtml = true;


            Client.UseDefaultCredentials = false;
            Client.Credentials = new System.Net.NetworkCredential(userName, passw);
            Client.Port = 587; // You can use Port 25 if 587 is blocked (mine is!)
            Client.Host = "smtp.office365.com";
            Client.DeliveryMethod = SmtpDeliveryMethod.Network;
            Client.EnableSsl = true;

            Client.Send(Msg);
        }
    }

    public class MessageContent
    {
        public string From { get; set; }
        public string FromName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
