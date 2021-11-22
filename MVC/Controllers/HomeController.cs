using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MVC.Models.ViewModels;
using System;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        ICategoryService _categoryService;
        IProductService _productService;
        
        public HomeController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
            
        }
        
        [HttpGet]
        public IActionResult Index(string id)
        {
            ProductListViewModel model = new ProductListViewModel();
            model.Categories = _categoryService.GetAll();

            if (id == null)
            {
                model.Products = _productService.GetAll();
            }
            else
            {
                model.Products = _productService.GetByCategoryId(Convert.ToInt32(id));
            }
            return View(model);
        }

        public IActionResult MyAccount()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }
    }
}
