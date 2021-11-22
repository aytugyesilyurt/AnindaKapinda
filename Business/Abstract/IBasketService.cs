using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IBasketService : IService<Basket>
    {
        ICollection<Basket> GetByUserId(int? id);
    }
}
