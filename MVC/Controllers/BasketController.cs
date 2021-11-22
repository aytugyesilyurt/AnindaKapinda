using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Filter;
using System;

namespace MVC.Controllers
{
    [UserFilter]
    public class BasketController : Controller
    {
        IProductService _productService;
        public BasketController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpPost]
        public ActionResult Add(int productId)
        {
            Product product = _productService.GetById(productId);
            string existBasketPrice = HttpContext.Session.GetString("basketTotalPrice");
            decimal totalBasketPrice = Convert.ToDecimal(existBasketPrice) + product.Price;
            HttpContext.Session.SetString("basketTotalPrice", totalBasketPrice.ToString());
            
            return Json(product);
        }

        [HttpPost]
        public ActionResult Remove(int productId)
        {
            Product product = _productService.GetById(productId);
            string existBasketPrice = HttpContext.Session.GetString("basketTotalPrice");
            decimal totalBasketPrice = Convert.ToDecimal(existBasketPrice) - product.Price;
            HttpContext.Session.SetString("basketTotalPrice", totalBasketPrice.ToString());

            return Json(product);
        }
    }
}
