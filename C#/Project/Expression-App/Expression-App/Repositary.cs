using System.Collections.Generic;
using System.Linq;

namespace Expression_App
{
    public class Repositary
    {
        private readonly ContactDbContext _contactDb;

        public Repositary()
        {
            _contactDb = ContactDbContext.Instance;
        }

        public void Add(Contact contact)
        {
            _contactDb.Users.Add(contact);
            _contactDb.SaveChanges();
        }

        //public List<Contact> GetAllContact()
        //{
        //    var list = _contactDb.Users.Where(m => m.Location == "Mumbai");
        //    return list;
        //} 

    }
}
