using System.Net;
using System.Net.Mail;

namespace BankingCore.Service
{
     public class EmailService
    {
        public void SendRegisterMail(string subject, string to, string name, string activationlink)
        {

            MailAddress receiepent = new MailAddress(to);
            MailAddress sender = new MailAddress("brijeshyyadav152@gmail.com");
            MailMessage mail = new MailMessage(sender, receiepent);
            mail.Subject = subject;
            mail.Body = "Hi " + name + "  !  Thanks so much for signing up !!!!";
            mail.Body += "We’d love to chat. Just hit reply to this email or any of our newsletters to get in touch with feedback, questions, or ideas for us ! ";
            mail.Body += "Click Here to login and activate your account " + activationlink + " ";

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;

            smtp.Credentials = new NetworkCredential("ecckeyvalidation@gmail.com", "himanshu123");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(mail);
            }
            catch
            {
                // ignored
            }
        }
    }
}
