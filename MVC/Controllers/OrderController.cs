using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Filter;

namespace MVC.Controllers
{
    [UserFilter]
    public class OrderController : Controller
    {
        int? uid;
        IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public IActionResult List()
        {
            uid = HttpContext.Session.GetInt32("id");
            if (uid != null) return View(_orderService.GetByUserId(uid));
            else return Redirect("/Account/Login");
        }

        public IActionResult Details(int orderId)
        {
            return View(_orderService.GetById(orderId));
        }
    }
}
