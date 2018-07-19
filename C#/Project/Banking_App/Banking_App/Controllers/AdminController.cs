using Banking_App.Services;
using Banking_App.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Banking_App.Controllers
{
    public class AdminController : Controller
    {
        UserService userService = new UserService();

        [HttpGet]
        public ActionResult AdminAccount()
        {
            AdminAccountViewModel vm = new AdminAccountViewModel();

            string userId = (string)HttpContext.Session["User"];
            var userList = userService.GetAllUser();
            vm.UserList = userList;

            return View(vm);
        }

        public ActionResult ChangeAccountStatus(string id)
        {
            var user = userService.CurrentUser(id);
            if (user.AccountStatus == "Active")
            {
                user.AccountStatus = "InActive";
            }
            else
                user.AccountStatus = "Active";
            userService.Save();
            return RedirectToAction("AdminAccount");
        }

        public ActionResult ViewTransaction(string id)
        {
            var user = userService.CurrentUser(id);
            var account = userService.GetAccount(user);
            AccountViewModel vm = new AccountViewModel();
            vm.User = user;
            vm.Account = account;
            return View(vm);
        }
    }
}