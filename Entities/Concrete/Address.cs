using Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public int CountyId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Directions { get; set; }
    }
}
