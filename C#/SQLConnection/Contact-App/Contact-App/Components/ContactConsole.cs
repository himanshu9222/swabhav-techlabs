using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Contact_App.Exceptions;
using Contact_App.DBConnection;

namespace Contact_App.Components
{
    class ContactConsole
    {
        //ContactStore store = new ContactStore();
        ContactDB contactDB = new ContactDB();

        public void Menu()
        {
            int flag = 1;
            while (flag != 0)
            {
                Console.WriteLine("\nType keywords to perform Action\n Add \tDisplay \tUpdate \tSearch \tDelete \tExit");
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "add":
                        contactDB.Insert(ContactDetails());
                        break;

                    case "display":
                        contactDB.Display();
                        break;

                    case "update": Console.WriteLine("Enter the name whose Constact is to be Updated");
                        contactDB.Update(Console.ReadLine());
                        break;

                    case "search": contactDB.SearchByName(Console.ReadLine());
                        break;

                    case "delete": contactDB.Delete(Console.ReadLine());
                        break;
                    case "exit":
                        flag = 0;
                        break;

                    default: Console.WriteLine("Enter Proper KeyWord");
                        break;
                }
            }
        }

        public Contact ContactDetails()
        {
            Contact details = new Contact();
            Console.WriteLine("Enter Name : ");
            details.Name = Console.ReadLine();
            Console.WriteLine("Enter Number : ");

            string no = Console.ReadLine();
            bool var = details.IsPhoneNumber(no);
            for (int i = 0; i < 3; i++)
            {
                if (var)
                {
                    details.Number = no;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a valid Number");
                    no = Console.ReadLine();
                    var = details.IsPhoneNumber(no);
                }
            }

            return details;
        }
    }
}
