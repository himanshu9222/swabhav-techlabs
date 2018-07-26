using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using BankingCore.Entity_Framework;
using BankingCore.Entity_Framework.Repositary;
using BankingCore.Enum;
using BankingCore.Models;
using BankingCore.Service;
using Banking_User.Models;

namespace Banking_User.Controllers
{
    public class UserController : Controller
    {
        private readonly EntityFrameworkRepositary<Account> _efrAccount = new EntityFrameworkRepositary<Account>();
        private readonly EntityFrameworkRepositary<User> _efrUser = new EntityFrameworkRepositary<User>();
        private readonly EntityFrameworkRepositary<Recipient> _efrRecipient = new EntityFrameworkRepositary<Recipient>();

        [HttpGet]
        public ActionResult Account()
        {
            AccountViewModel vm = new AccountViewModel();
            using (new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                vm.UserName = user.Name;
                //var account = _efrAccount.GetDbSet().Where( x=> x.User.Id == user.Id).Include( m=> m.TransactionList).ToList();
                //vm.TransactionList = account[0].TransactionList;
            }

            return View(vm);
        }

        [HttpPost]
        public ActionResult Account(AccountViewModel vm)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                vm.UserName = user.Name;
                var account = _efrAccount.GetDbSet().Where(x => x.User.Id == user.Id).Include(m => m.TransactionList).ToList();
                bool flag = false;

                foreach (var acc in account)
                {
                    if (acc.AccountType.Equals(AccountType.SAVING.ToString()))
                    {
                        flag = true;
                        vm.Message = "Saving Account Exist for User" + user.Name + " Amount " + acc.Balance;
                    }
                }

                if (flag == false)
                {
                    Account savingAccount = new Account(AccountType.SAVING.ToString(), 5000) { User = user };
                    _efrAccount.Add(savingAccount);
                    vm.Message = "Account Successfully Created";
                }
                unitOfWork.SaveChanges();
            }
            return View(vm);
        }

        [HttpGet]
        public ActionResult Passbook()
        {
            PassbookViewModel vm = new PassbookViewModel();
            using (new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                vm.Username = user.Name;
                return View(vm);
            }
        }

        [HttpPost]
        public ActionResult Passbook(PassbookViewModel vm)
        {
            using (new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                Account account = null;
                try
                {
                    account =
                         _efrAccount.GetDbSet()
                             .Where(x => x.User.Id == user.Id)
                             .Where(x => x.AccountType == vm.AccountType)
                             .Include(m => m.TransactionList)
                             .First();
                }
                catch (Exception)
                {
                    // ignored
                }
                vm.Flag = false;

                if (account != null)
                {
                    vm.Flag = true;
                    vm.Account = account;
                }


                if (vm.Flag == false)
                {
                    vm.Message = "Account does not exist";
                }

                return View(vm);
            }
        }

        [HttpGet]
        public ActionResult Transaction()
        {
            using (new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                TransactionViewModel vm = new TransactionViewModel();
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                vm.UserName = user.Name;
                return View(vm);
            }
        }

        [HttpPost]
        public ActionResult Transaction(TransactionViewModel vm)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                if (ModelState.IsValid)
                {
                    AuthenticationService authenticate = new AuthenticationService();
                    var userEmail = (string)HttpContext.Session["User"];
                    var user = authenticate.GetUser(userEmail);
                    Account account = null;
                    try
                    {
                        account =
                             _efrAccount.GetDbSet()
                                 .Where(x => x.User.Id == user.Id)
                                 .Where(x => x.AccountType == vm.AccountType)
                                 .Include(m => m.TransactionList)
                                 .First();
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                    vm.UserName = user.Name;
                    vm.Flag = false;

                    if (account != null)
                    {
                        vm.Flag = true;
                        vm.Account = account;
                        Transaction transaction = new Transaction(vm.Amount, vm.TransactionType, DateTime.Now)
                        {
                            Account = account
                        };
                        vm.Account.TransactionList.Add(transaction);
                        vm.Message = "Transaction Successfull";
                        //_efrTransaction.Add(transaction);
                    }


                    if (vm.Flag == false)
                    {
                        vm.Message = "Account does not exist";
                    }
                    unitOfWork.SaveChanges();
                }

                return View(vm);
            }
        }

        [HttpGet]
        public ActionResult Recipient()
        {
            RecipientViewModel vm = new RecipientViewModel();
            using (new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                vm.UserName = user.Name;
                vm.SelectedList = PopulateList();

            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult Recipient(RecipientViewModel vm)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                vm.UserName = user.Name;

                if (ModelState.IsValid && vm.Name != null)
                {

                    vm.SelectedList = PopulateList();

                    try
                    {
                        var account =
                            _efrAccount.GetDbSet()
                                .Where(x => x.User.Id == user.Id)
                                .Where(x => x.AccountType == vm.AccountType)
                                .Include(m => m.TransactionList)
                                .First();
                        var recipient =
                            _efrRecipient.GetDbSet()
                                .Where(x => x.User.Id == user.Id)
                                .Where(x => x.Name == vm.Name)
                                .First();
                        recipient.Balance += vm.Amount;
                        account.TransactionList.Add(new Transaction(vm.Amount, TransactionType.WITHDRAW.ToString(),
                            DateTime.Now));
                        vm.Message = "Transaction successful with Recipient";
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                    unitOfWork.SaveChanges();
                }
            }
            return View(vm);
        }

        [HttpGet]
        public ActionResult AddRecipient()
        {
            AddRecipientViewModel vm = new AddRecipientViewModel();

            using (
                var unitOfWork =
                    new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                vm.UserName = user.Name;
            }
            return View(vm);
        }

        [HttpPost]
        public ActionResult AddRecipient(AddRecipientViewModel vm)
        {
            using (
                var unitOfWork =
                    new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                vm.UserName = user.Name;
                if (ModelState.IsValid)
                {
                    try
                    {
                        var users = _efrUser.GetDbSet()
                            .Where(m => m.Id == user.Id)
                            .Include(m => m.RecipientList)
                            .First();

                        Recipient recipient = new Recipient(vm.Name, vm.Amount);
                        users.RecipientList.Add(recipient);
                        vm.Message = "Recipient Successfully Added";
                        unitOfWork.SaveChanges();
                        return RedirectToAction("Recipient", "User");
                    }
                    catch (Exception) { }
                }
            }
            return View(vm);
        }

        public ActionResult Logout()
        {
            HttpContext.Session["User"] = null;
            return RedirectToAction("Login", "Login");
        }

        public List<SelectListItem> PopulateList()
        {
            using (new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Reading))
            {
                List<SelectListItem> list = new List<SelectListItem>();
                AuthenticationService authenticate = new AuthenticationService();
                var userEmail = (string)HttpContext.Session["User"];
                var user = authenticate.GetUser(userEmail);
                try
                {
                    var recipientList =
                         _efrRecipient.GetDbSet()
                             .Where(x => x.User.Id == user.Id)
                             .ToList();

                    foreach (var recipient in recipientList)
                    {
                        list.Add(new SelectListItem
                        {
                            Text = recipient.Name,
                            Value = recipient.Id.ToString(),
                        });
                    }
                }
                catch (Exception)
                {
                    // ignored
                }


                return list;
            }
        }
    }
}