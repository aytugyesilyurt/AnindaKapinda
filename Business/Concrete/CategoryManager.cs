using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public bool Add(Category entity)
        {
            return _categoryDal.Add(entity);
        }

        public bool Delete(Category entity)
        {
            return _categoryDal.Delete(entity);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(c => c.CategoryId == id);
        }

        public bool Update(Category entity)
        {
            return _categoryDal.Update(entity);
        }
    }
}
