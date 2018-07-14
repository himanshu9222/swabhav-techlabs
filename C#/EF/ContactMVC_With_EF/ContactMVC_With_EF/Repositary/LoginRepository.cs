using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactMVC_With_EF.Repositary
{
    public class LoginRepository
    {
        private readonly ContactDbContext contactDb;

        public LoginRepository(ContactDbContext contactDbContext)
        {
            contactDb = contactDbContext;
        }

        public string GetPassword(string userName)
        {
            var user = contactDb.Logins.SingleOrDefault(m => m.UserName == userName.ToUpper());
            return user.Password;
        }
    }
}