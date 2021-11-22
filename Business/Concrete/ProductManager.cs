using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Linq;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public bool Add(Product entity)
        {
            return _productDal.Add(entity);
        }

        public bool Delete(Product entity)
        {
            return _productDal.Delete(entity);
        }

        public ICollection<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetByCategoryId(int categoryId)
        {
            return _productDal.GetAll().Where(p => p.CategoryId == categoryId).ToList();
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(p => p.ProductId == id);
        }

        public bool Update(Product entity)
        {
            return _productDal.Update(entity);
        }
    }
}
