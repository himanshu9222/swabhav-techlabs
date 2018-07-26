using Banking_User.Models;
using BankingCore.Models;
using BankingCore.Service;
using BankingCore.Enum;
using BankingCore.Entity_Framework.Repositary;
using CaptchaMvc.HtmlHelpers;
using System.Web.Mvc;
using BankingCore.Entity_Framework;

namespace Banking_User.Controllers
{
    public class LoginController : Controller
    {
        private readonly EntityFrameworkRepositary<User> _efrUser = new EntityFrameworkRepositary<User>();
        private readonly EntityFrameworkRepositary<Account> _efrAccount = new EntityFrameworkRepositary<Account>();

        [HttpGet]
        public ActionResult Login()
        {
            LoginViewModel vm = new LoginViewModel();
            return View(vm);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel vm)
        {
            AuthenticationService authenticate = new AuthenticationService();
            if (ModelState.IsValid)
            {
                var user = authenticate.GetUser(vm.UserId);

                if (HttpContext.Session["User"] == null)
                    HttpContext.Session["User"] = user.Gmail;
                 
                vm.Message = "Your Account is Not verified";
                if (this.IsCaptchaValid("Invalid Captcha") && user.Verified == "True" && user != null)
                {
                    vm.Message = "Enter Proper Name and Password";
                    var state = authenticate.CheckCredentials(vm.UserId, vm.Password);
                    if (state)
                    {
                        //if (user.Role == UserType.ADMIN.ToString())
                        //{
                        //    return RedirectToAction("AdminAccount", "Admin");
                        //}
                        //if (user.AccountStatus == AccountStatus.INACTIVE.ToString())
                        //{
                        //    vm.Message = "Account is Locked";
                        //    return View(vm);
                        //}
                        return RedirectToAction("Account", "User");
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
                
                vm.Role = UserType.USER.ToString();
                vm.AccountStatus = AccountStatus.ACTIVE.ToString();
                vm.Verified = false.ToString();
                using (
                    var unitOfWork =
                        new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
                {
                    User user = new User(vm.Gmail, vm.Name, vm.Password, vm.Age, vm.Gender, vm.Role, vm.AccountStatus,
                        vm.Verified);
                    Account accountCurrent = new Account(AccountType.CURRENT.ToString(), 10000) {User = user};
                    _efrAccount.Add(accountCurrent);
                    _efrUser.Add(user);
                    unitOfWork.SaveChanges();
                    string link = "http://localhost:53934/Login/Verify?name=" + user.Gmail;
                    EmailService emailService = new EmailService();
                    emailService.SendRegisterMail("Activate Account", user.Gmail, user.Name, link);
                    return RedirectToAction("Login");
                }
            }
            return View(vm);
        }

        public ActionResult Verify(string name)
        {
            using (var unitOfWork = new UnitOfWork.UnitOfWorkScope<BankingDbContext>(UnitOfWork.UnitOfWorkScopePurpose.Writing))
            {
                AuthenticationService authenticate = new AuthenticationService();
                var user = authenticate.GetUser(name);
                user.Verified = "True";
                unitOfWork.SaveChanges();
                return RedirectToAction("Login");
            }
        }
    }
}