using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace SendMail_App
{
    class SendMail
    {
        public void Send(string recieverMailAddress , string subject ,string body)
        {
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 25);
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = "gansterhimanshu@gmail.com";
            nc.Password = "parthmehta";

            smtp.Credentials = nc;

            MailAddress from = new MailAddress("gansterhimanshu@gmail.com");

            MailAddress reciever = new MailAddress(recieverMailAddress);

            MailMessage myMessage = new MailMessage(from, reciever);
            myMessage.Subject = subject.Trim();
            myMessage.Body = body.Trim();
            myMessage.Priority = MailPriority.High;
            smtp.Send(myMessage);
        }
    }
}
