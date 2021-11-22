using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using MVC.Filter;

namespace MVC.Controllers
{
    [UserFilter]
    public class ProductController : Controller
    {
        IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult List()
        {
            return View(_productService.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.Add(product);
            return RedirectToAction("List");
        }

        public IActionResult Detail(int id)
        {
            return View(_productService.GetById(id));
        }

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            _productService.Update(product);
            return RedirectToAction("List");
        }

        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            _productService.Delete(product);
            return RedirectToAction("List");
        }
    }
}
