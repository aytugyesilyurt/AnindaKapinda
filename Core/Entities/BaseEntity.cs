using System;

namespace Core.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            IsActive = true;
            CreatedDate = DateTime.Now;
        }

        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
