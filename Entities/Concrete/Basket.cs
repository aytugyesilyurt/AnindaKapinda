using Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Basket : IEntity
    {
        public Basket()
        {
            //BasketDetail = new HashSet<BasketDetail>();
        }

        [Key]
        public int BasketId { get; set; }
        public int UserId { get; set; }
        [Required]
        public bool IsActive { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }

        public User User { get; set; }
        public BasketDetail BasketDetail { get; set; }
    }
}
