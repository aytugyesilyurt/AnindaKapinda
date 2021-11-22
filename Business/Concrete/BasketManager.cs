using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public bool Add(Basket entity)
        {
            return _basketDal.Add(entity);
        }

        public bool Delete(Basket entity)
        {
            return _basketDal.Delete(entity);
        }

        public ICollection<Basket> GetAll()
        {
            return _basketDal.GetAll();
        }

        public Basket GetById(int id)
        {
            return _basketDal.GetById(b =>b.BasketId == id);
        }

        public ICollection<Basket> GetByUserId(int? id)
        {
            return id == null ? _basketDal.GetAll() : _basketDal.GetAll(b => b.UserId == id);
        }

        public bool Update(Basket entity)
        {
            return _basketDal.Update(entity);
        }
    }
}
