using System;
using System.Net.Mail;

namespace ExampleSRP.src.Correct.Service
{
    public static class EmailService
    {
        public static bool IsValid(string email)
        {
            if(!email.Contains("@"))
                return false;
            
            return true;
        }

        public static void SendEmail(string from, string to, string subject, string email)
        {
            var mail = new MailMessage(from, to);
            var client = new SmtpClient
            {
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Host = "smtp.google.com"
            };

            mail.Subject = subject;
            mail.Body = email;
            client.Send(mail);
        }
    }
}