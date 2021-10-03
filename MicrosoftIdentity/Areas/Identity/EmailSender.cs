using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicrosoftIdentity.Areas.Identity
{
    public class EmailSender : IEmailSender
    {
        public string ApiKey { get; set; }
        public string FromName { get; set; }
        public string FromEmail { get; set; }
        public EmailSender(IConfiguration config)
        {
            ApiKey = config["MailSettings:APIKey"];
            FromName = config["MailSettings:FromName"];
            FromEmail = config["MailSettings:FromEmail"];
        }
        public async Task SendEmailAsync(string email, string subject, string Message)
        {
            var client = new SendGridClient(ApiKey);
            var msg = new SendGridMessage()
            {
                From= new EmailAddress(FromEmail,FromName),
               Subject=subject,
               PlainTextContent=Message,
               HtmlContent=Message
            };
            msg.AddTo(new EmailAddress(email));
            msg.SetClickTracking(false, false);
            await client.SendEmailAsync(msg);
        }
       
    }
}
