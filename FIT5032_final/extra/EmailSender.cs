using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_final.extra
{
    public class EmailSender
    {

        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String toEmail, String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "FIT5032 Example Email User");
            var to = new EmailAddress(toEmail, "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }

    }
}