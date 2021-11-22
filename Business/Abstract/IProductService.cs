using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService : IService<Product>
    {
        List<Product> GetByCategoryId(int categoryId);
    }
}
