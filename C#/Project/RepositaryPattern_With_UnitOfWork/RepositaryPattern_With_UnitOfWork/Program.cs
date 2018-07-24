using System;
using RepositaryPattern_With_UnitOfWork.EntityFramework.Repositary;
using RepositaryPattern_With_UnitOfWork.EntityFramework.Specification;
using RepositaryPattern_With_UnitOfWork.Models;

namespace RepositaryPattern_With_UnitOfWork
{
    public class Program
    {
        private static EntityFrameworkRepositary<Contact> _contact;
        static void Main(string[] args)
        {
            _contact = new EntityFrameworkRepositary<Contact>();
            //var flag = true;

            var cbyname = _contact.Find(new FindByNameSpecification(
                           new ContactSearchCriteriaByName
                           {
                               Name = "Himasnhu",
                               Location = "Mumbai"
                           }
                           ));
            foreach (var contact in cbyname)
            {
                Console.WriteLine("Id " + contact.Id +
                    " Name " + contact.Name +
                    " Number " + contact.Number +
                    " Location " + contact.Location);
            }


            //while (flag)
            //{
            //    Console.WriteLine("Enter the following KeyWord \nAdd  Display  Search  SearchByName  Delete  Exit ");
            //    string choice = Console.ReadLine();
            //    switch (choice.ToLower())
            //    {
            //        case "add":
            //            _contact.Add(Input());
            //            break;

            //        case "display":
            //            var contactList = _contact.Get();

            //            foreach (var contact in contactList)
            //            {
            //                Console.WriteLine("Id "+contact.Id + 
            //                    " Name "+contact.Name +
            //                    " Number "+contact.Number+
            //                    " Location "+contact.Location);
            //            }
            //            break;

            //        case "search":
            //            string ii = Console.ReadLine();
            //            var searchId = Guid.Parse(ii);

            //            var c =_contact.GetById(searchId);
            //            Console.WriteLine("Id " + c.Id +
            //                    " Name " + c.Name +
            //                    " Number " + c.Number +
            //                    " Location " + c.Location);
            //            break;

            //        case "searchbyname":

            //            var cbyname =_contact.Find(new FindByNameSpecification(
            //                new ContactSearchCriteriaByName
            //                {
            //                    Name = "Himanshu",
            //                    Location =  "Mumbai"
            //                }
            //                ));
            //            foreach (var contact in cbyname)
            //            {
            //                Console.WriteLine("Id " + contact.Id +
            //                    " Name " + contact.Name +
            //                    " Number " + contact.Number +
            //                    " Location " + contact.Location);
            //            }
            //            break;

            //        case "delete":
            //            string i = Console.ReadLine();
            //            var id =Guid.Parse( i);
            //            _contact.Delete(id);
            //            break;

            //        case "exit":
            //            flag = false;
            //            break;

            //        default: Console.WriteLine("Enter Proper KeyWord");
            //            break;

            //    }
            //}
        }

        public static Contact Input()
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Number");
            string number = Console.ReadLine();
            Console.WriteLine("Enter Location");
            string location = Console.ReadLine();
            Contact c = new Contact(name,number,location);
            return c;
        }

    }
}
