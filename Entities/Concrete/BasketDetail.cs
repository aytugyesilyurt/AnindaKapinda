using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class BasketDetail : IEntity
    {
        [Key]
        public int BasketDetailId { get; set; }
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        [Required]
        public decimal Quantity { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
    }
}
