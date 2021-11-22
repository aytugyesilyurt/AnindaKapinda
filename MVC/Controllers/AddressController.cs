using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Filter;

namespace MVC.Controllers
{
    [UserFilter]
    public class AddressController : Controller
    {
        int? uid;
        IAddressService _adressService;

        public AddressController(IAddressService adressService)
        {
            _adressService = adressService;
        }

        public IActionResult List(int userId)
        {
            uid = HttpContext.Session.GetInt32("id");
            return View(_adressService.GetByUserId(uid));
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Address address)
        {
            _adressService.Add(address);
            return RedirectToAction("List");
        }

        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Address address)
        {
            _adressService.Update(address);
            return RedirectToAction("List");
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Address address)
        {
            _adressService.Delete(address);
            return RedirectToAction("List");
        }
    }
}
