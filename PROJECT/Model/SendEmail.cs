using System.Net.Mail;
using System.Net;

namespace PROJECT.Model
{
    internal class SendEmail
    {
        public void SendEmailToUser(string email ,string body)
        {
            String fromMail = "elab41938@gmail.com";
            String fromPassword = "dzxdqzsoamgxirzq";

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "Notification";
            message.To.Add(new MailAddress(email));
            message.Body = body;
            message.IsBodyHtml = true;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPassword),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }
    }
}
