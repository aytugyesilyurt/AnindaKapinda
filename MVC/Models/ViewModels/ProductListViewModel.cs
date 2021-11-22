using Entities.Concrete;
using System.Collections.Generic;

namespace MVC.Models.ViewModels
{
    public class ProductListViewModel
    {
        public ProductListViewModel()
        {
            Products = new List<Product>();
            Categories = new List<Category>();
        }
        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}
