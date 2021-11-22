using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public User()
        {
            Adresses = new HashSet<Address>();
            CreditCards = new HashSet<CreditCard>();
            Orders = new HashSet<Order>();
            Baskets = new HashSet<Basket>();
        }

        [Key]
        public int UserId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Password { get; set; }
        public Guid? ValidationCode { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Basket> Baskets { get; set; }
        public ICollection<Address> Adresses { get; set; }
        public ICollection<CreditCard> CreditCards { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
