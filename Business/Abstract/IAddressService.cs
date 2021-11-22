using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface IAddressService : IService<Address>
    {
        ICollection<Address> GetByUserId(int? id);
    }
}
