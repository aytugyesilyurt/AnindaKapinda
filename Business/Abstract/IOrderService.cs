using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IOrderService : IService<Order>
    {
        ICollection<Order> GetByUserId(int? id);
    }
}
