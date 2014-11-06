using System.Web.Http;
using BlaineSmith.Business;

namespace BlaineSmith.API.Email
{
    public class SendEmailController : ApiController
    {
        readonly EmailManager _em = new EmailManager();
        // POST api/sendemail
        public void Post([FromBody]MessageContent emailValues)
        {
            _em.SendEmail(emailValues);
        }
    }
}
