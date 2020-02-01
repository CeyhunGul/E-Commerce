using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.COMMON
{
    public class MailSender
    {
        public static void SendEmail(string email, string subject, string message)
        {
            //Mail gönderim ayarları
            MailMessage sender = new MailMessage();
            sender.From = new MailAddress("test@yazilimfikirleri.com", "NTierECommerce");
            sender.To.Add(email);
            sender.Subject = subject;
            sender.Body = message;

            //Smtp ayarları
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("test@yazilimfikirleri.com", "YMS9515yms");
            smtp.Port = 587;
            smtp.Host = "mail.yazilimfikirleri.com";
            smtp.EnableSsl = false;
            smtp.Send(sender);

        }
    }
}
