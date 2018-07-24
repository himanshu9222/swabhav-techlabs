using System;
using System.Linq;

namespace Expression_App
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args == null) throw new ArgumentNullException(nameof(args));
            ContactDbContext db = ContactDbContext.Instance;
            
            //List<Contact> contactlist = new List<Contact>()
            //{
            //    new Contact("Himanshu","9876543210","Mumbai"),
            //    new Contact("Pratik","9876543210","Mumbai"),
            //    new Contact("Prasad","9876543210","Mumbai"),
            //    new Contact("Santosh","9876543210","Mumbai"),
            //    new Contact("Dheeraj","9876543210","Mumbai"),
            //    new Contact("Sarvesh","9876543210","Mumbai"),
            //};

            //foreach (var contact in contactlist)
            //{
            //    db.Users.Add(contact);
            //}
            //db.SaveChanges();

            
            IQueryable<Contact> contactOfMumbai = db.Users.Where(m=> m.Location =="Mumbai");

            IQueryable<Contact> topContactOfMumbai = contactOfMumbai.Take(5);

            char[] splitchar = {' '};
            IQueryable<string> upperCaseContact = topContactOfMumbai.Select(m => m.Name.ToUpper());

            //string str = upperCaseContact.Single().Split(splitchar)[0];
            Console.WriteLine(upperCaseContact.First());




            Console.WriteLine(
                upperCaseContact
                .ToList()
                .First()
                .Split(splitchar)[0]);

            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
