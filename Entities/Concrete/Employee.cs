using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public Employee()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string RoleType { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
