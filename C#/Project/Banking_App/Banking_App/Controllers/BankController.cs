using Banking_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CaptchaMvc.HtmlHelpers;
using Banking_App.Services;
using Banking_App.Models;
using System.IO;

namespace Banking_App.Controllers
{
    public class BankController : Controller
    {
        UserService userService = new UserService();

        [HttpGet]
        public ActionResult UserLogin()
        {
            UserLoginViewModel vm = new UserLoginViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult UserLogin(UserLoginViewModel vm)
        {

            if (ModelState.IsValid)
            {
                User user = userService.CurrentUser(vm.UserId);

                if (HttpContext.Session["User"] == null)
                {
                    HttpContext.Session["User"] = user.UserId;
                }
                vm.Message = "Enter Proper Captcha";
                if (this.IsCaptchaValid("Invalid Captcha"))
                {
                    vm.Message = "Enter Proper Name and Password";
                    var state = userService.CheckCredentials(vm);
                    if (state)
                    {
                        if (user.Role == "A")
                        {
                            return RedirectToAction("AdminAccount", "Admin");
                        }
                        if (user.AccountStatus == "InActive")
                        {
                            vm.Message = "Account is Locked";
                            return View(vm);
                        }
                        return RedirectToAction("Account", "Bank");
                    }
                }
            }
            return View(vm);
        }

        [HttpGet]
        public ActionResult Register()
        {
            RegisterViewModel vm = new RegisterViewModel(); 
            return View(vm);
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                userService.AddUser(vm);
                return RedirectToAction("UserLogin");
            }
            return View(vm);
        }

        [HttpGet]
        public ActionResult Account()
        {
            if (HttpContext.Session["User"] == null)
            {
                return RedirectToAction("UserLogin");
            }
            string userId = (string)HttpContext.Session["User"];
            var user = userService.CurrentUser(userId);
            var account = userService.GetAccount(user);

            AccountViewModel vm = new AccountViewModel();
            vm.User = user;
            vm.Account = user.Account;
            return View(vm);
        }

        [HttpGet]
        public ActionResult Transaction()
        {
            if (HttpContext.Session["User"] == null)
            {
                return RedirectToAction("UserLogin");
            }
            TransactionViewModel vm = new TransactionViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Transaction(TransactionViewModel vm)
        {
            string userId = (string)HttpContext.Session["User"];
            var user = userService.CurrentUser(userId);
            var account = userService.GetAccount(user);
            var flag = false;

            if (vm.TransactionAmount != 0 && vm.TransactionType != null)
            {
                if (vm.TransactionType == "W")
                {
                    var b = account.Balance - vm.TransactionAmount;
                    flag = (b <= 0);
                    if (flag)
                    {
                        vm.Message = "Insufficient balance";
                        return View(vm);
                    }
                }
                userService.Save(account, user, vm.TransactionAmount, vm.TransactionType);
                return RedirectToAction("Account");
            }
            return View(vm);
        }

        public ActionResult Logout()
        {
            HttpContext.Session["User"] = null;
            return RedirectToAction("UserLogin");
        }

        public ActionResult Export()
        {
            string userId = (string)HttpContext.Session["User"];
            var user = userService.CurrentUser(userId);
            var account = userService.GetAccount(user);
            string textWrite = "";

            foreach (Transaction t in account.TransactionList)
            {
                textWrite = textWrite + t.ToString();
            }

            TextWriter writer =
                new StreamWriter
                ("C:\\Swabhav Techlabs\\cloudrepository\\MyFirstProject\\C#\\Project\\Banking_App\\Banking_AppTransactionFileForUser" + user.UserId + ".txt");
            writer.WriteLine(textWrite);
            writer.Close();
            return RedirectToAction("Account");
        }
    }
}