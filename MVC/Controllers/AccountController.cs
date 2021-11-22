using Business;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace MVC.Controllers
{
    public class AccountController : Controller
    {
        IUserService _userService;
        
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string mail, string password)
        {
            User user = _userService.GetAll().FirstOrDefault(u => u.Mail == mail && u.Password == password);
            if (user != null)
            {
                HttpContext.Session.SetInt32("id", user.UserId);
                HttpContext.Session.SetString("fullname", user.FirstName + " " + user.LastName);
                return Redirect("/Home/Index");
            }
            return Redirect("Register");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return Redirect("/Home/Index");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User u)
        {
            MailHelper.SendMail(u);
            _userService.Add(u);
            return RedirectToAction("Login");
        }
    }
}
