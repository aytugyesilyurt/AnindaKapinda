using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Filter;

namespace MVC.Controllers
{
    [UserFilter]
    public class CreditCardController : Controller
    {
        int? uid;
        ICreditCardService _creditCardService;

        public CreditCardController(ICreditCardService creditCardService)
        {
            _creditCardService = creditCardService;
        }

        public IActionResult List()
        {
            uid = HttpContext.Session.GetInt32("id");
            return View(_creditCardService.GetByUserId(uid));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreditCard creditCard)
        {
            uid = HttpContext.Session.GetInt32("id");
            if (uid != null) { creditCard.UserId = (int)uid; }
            _creditCardService.Add(creditCard);
            return RedirectToAction("List");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(CreditCard creditCard)
        {
            _creditCardService.Update(creditCard);
            return RedirectToAction("List");
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(CreditCard creditCard)
        {
            _creditCardService.Delete(creditCard);
            return RedirectToAction("List");
        }
    }
}
