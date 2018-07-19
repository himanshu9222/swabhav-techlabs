using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankModelTest
{
   public  class Program
    {
        public static void Main(string[] args)
        {
            BankingDbContext db = new BankingDbContext();
            //User user1 = new User("himanshu", "Himanshu Lal", "123456", "U", "Active");
            //Transaction t = new Transaction(50000, "W", DateTime.Today);

            //Account acc = new Account(1000);
            //acc.TransactionList.Add(t);
            //user1.Account = acc;
            //db.Users.Add(user1);
            //Console.WriteLine("Done");

            //User user1 = new User("prasad", "Prasad Patil", "123456", "U", "Active");
            //Transaction t = new Transaction(50000, "W", DateTime.Now);

            //Account acc = new Account(1000);
            //acc.TransactionList.Add(t);
            //user1.Account = acc;
            //db.Users.Add(user1);
            //Console.WriteLine("Done");

            var user = db.Users.Where(m => m.UserId == "himanshu").Include(m => m.Account).First();

            var account = db.Accounts.Where(m => m.AccountId == user.Account.AccountId).Include(m => m.TransactionList).First();

            //db.SaveChanges();
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
