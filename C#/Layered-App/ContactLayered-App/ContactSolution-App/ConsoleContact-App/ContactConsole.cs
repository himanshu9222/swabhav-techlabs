using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactCore.Components;
using ContactCore.Exceptions;



namespace ConsoleContact_App
{
    class ContactConsole
    {
        ContactStore store = new ContactStore();

        public void Menu()
        {
            Console.WriteLine("Size of List is " + store.ContactListSize);

            int flag = 1;
            while (flag != 0)
            {
                Console.WriteLine("\nType keywords to perform Action\n Add \tDisplay Search \tUpdate \tRemove \tExit");
                string choice = Console.ReadLine();
                switch (choice.ToLower())
                {
                    case "add":
                        store.Add(ContactDetails());
                        break;

                    case "display":
                        Display(store.ContactList);
                        break;

                    case "search":
                        try
                        {
                            List<Contact> matching = store.Search(Console.ReadLine());
                            Display(matching);
                        }
                        catch (StudentNotFoundException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }

                        break;

                    case "update":
                        Console.WriteLine("Ënter the name you want to update");
                        store.Update(Console.ReadLine());
                        break;

                    case "remove":
                        store.Remove(Console.ReadLine());
                        Display(store.ContactList);
                        break;

                    case "exit":
                        store.Serialize();
                        flag = 0;
                        break;

                    default:
                        Console.WriteLine("Enter Proper KeyWord");
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

        public void Display(List<Contact> list)
        {
            if (list.Count != 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    Contact detail = list[i];
                    Console.WriteLine(detail.ToString());
                }
            }
        }

    }
}
