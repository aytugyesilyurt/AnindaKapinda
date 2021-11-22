using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key] 
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
