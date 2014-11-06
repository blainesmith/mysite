using System;
using System.Web.Http;
using Microsoft.Exchange.WebServices.Autodiscover;
using Microsoft.Exchange.WebServices.Data;

namespace BlaineSmith.Business
{
    public class EmailManager
    {
        //public MailMessage Msg;
        //public SmtpClient Client;

        //public EmailManager()
        //{
        //    Msg = new MailMessage();
        //    Client = new SmtpClient();
        //}

        public void SendEmail([FromBody] MessageContent content)
        {
            const string userName = "blaine@blainesmith.net";
            const string passw = "Broncos1!";
            //const string toEmail = "blaine@blainesmith.net";
            //const string toName = "Blaine Smith";

            // Create a new Exchange service object
 
            var service = new ExchangeService(ExchangeVersion.Exchange2010_SP1)
            {
                Credentials = new WebCredentials(userName, passw)
            };
 
            // Set user login credentials

            try
            {
                //Set Office 365 Exchange Webserivce Url
                const string serviceUrl = "https://outlook.office365.com/ews/exchange.asmx";
                service.Url = new Uri(serviceUrl);

                if (content == null) return;
                var emailContent =
                    string.Concat(string.Format("From: {0}<br>Email: {1}<br> Subject: {2}<br>Body: {3}", content.FromName, content.FromEmail, content.Subject, content.Body));

                var emailMessage = new EmailMessage(service)
                {
                    Sender = content.FromName,
                    From = content.FromName,
                    Subject = "Website Contact",
                    Body = new MessageBody(emailContent)
                };
             
                emailMessage.ToRecipients.Add(userName);
                emailMessage.SendAndSaveCopy();
            }

             catch (AutodiscoverRemoteException exception)
            {
                 // handle exception
                 throw exception;
            }
        }
    }

    public class MessageContent
    {
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
