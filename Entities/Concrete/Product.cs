using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        [Key]
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? DiscountedPrice { get; set; }
        
        public Category Category { get; set; }
    }
}
