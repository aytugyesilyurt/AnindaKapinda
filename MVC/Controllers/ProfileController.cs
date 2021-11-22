using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Filter;

namespace MVC.Controllers
{
    [UserFilter]
    public class ProfileController : Controller
    {
        int? uid;
        IUserService _userService;

        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Profile(int userId)
        {
            uid = HttpContext.Session.GetInt32("id");
            return View(_userService.GetById((int)uid));
            
        }
        public IActionResult ProfileEdit(int userId)
        {
            return View();
            
        }
        [HttpPost]
        public IActionResult ProfileEdit(User user)
        {
            _userService.Update(user);
            return RedirectToAction("Profile");

        }

        public IActionResult ProfileDelete(int userId)
        {
            return View();
        }
        [HttpPost]
        public IActionResult ProfileDelete(User user)
        {
            _userService.Update(user);
            return RedirectToAction("Profile");
        }
    }
}
