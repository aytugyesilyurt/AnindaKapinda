using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class CreditCard : IEntity
    {
        [Key]
        public int CreditCardId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int CardNumber { get; set; }

    }
}
