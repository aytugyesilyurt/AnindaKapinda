using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        [Key]
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string DeliveryAdress { get; set; }
        [Required]
        public string Status { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime? DeliverDate { get; set; }
    }
}
