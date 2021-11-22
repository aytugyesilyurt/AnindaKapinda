using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICreditCardService : IService<CreditCard>
    {
        ICollection<CreditCard> GetByUserId(int? id);
    }
}
