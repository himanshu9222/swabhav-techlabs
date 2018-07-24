using BankingCore.Entity_Framework.Repositary;
using BankingCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCore.Service
{
    public class AuthenticationService
    {
        private readonly UserRepositary userRepositary;

        public AuthenticationService()
        {
            userRepositary = new UserRepositary(BankingDbContext.Instance);
        }

        public bool CheckCredentials(string gmail, string password)
        {
            try
            {
                if (userRepositary.GetPassword(gmail) == password)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
