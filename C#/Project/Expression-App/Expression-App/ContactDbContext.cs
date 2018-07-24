using System.Data.Entity;

namespace Expression_App
{
    public class ContactDbContext :DbContext
    {
        public DbSet<Contact> Users { get; set; }

        public ContactDbContext(): base("name=ContactDbContext")
        {

        }

        private static readonly object Padlock = new object();
        private static ContactDbContext _instance;

        public static ContactDbContext Instance
        {
            get
            {
                lock (Padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new ContactDbContext();
                    }
                    return _instance;
                }
            }
        }
    }
}
