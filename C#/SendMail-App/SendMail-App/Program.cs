using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SendMail_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Mail Address of Reciever");
            string reciever = Console.ReadLine();

            Console.WriteLine("Enter Mail Subject");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter Mail Body");
            string body = Console.ReadLine();

            SendMail send = new SendMail();
            send.Send(reciever,subject,body);
            Console.ReadKey();

        }
    }
}
