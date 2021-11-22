using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BasketDetailManager : IBasketDetailService
    {
        IBasketDetailDal _basketDetailDal;

        public BasketDetailManager(IBasketDetailDal basketDetailDal)
        {
            _basketDetailDal = basketDetailDal;
        }

        public bool Add(BasketDetail entity)
        {
            return _basketDetailDal.Add(entity);
        }

        public bool Delete(BasketDetail entity)
        {
            return _basketDetailDal.Delete(entity);
        }

        public ICollection<BasketDetail> GetAll()
        {
            return _basketDetailDal.GetAll();
        }

        public BasketDetail GetById(int id)
        {
            return _basketDetailDal.GetById(bd => bd.BasketDetailId == id);
        }

        public bool Update(BasketDetail entity)
        {
            return _basketDetailDal.Update(entity);
        }
    }
}
