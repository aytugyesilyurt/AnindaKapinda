using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class CreditCardManager : ICreditCardService
    {
        ICreditCardDal _creditCardDal;

        public CreditCardManager(ICreditCardDal creditCardDal)
        {
            _creditCardDal = creditCardDal;
        }

        public bool Add(CreditCard entity)
        {
            return _creditCardDal.Add(entity);
        }

        public bool Delete(CreditCard entity)
        {
            return _creditCardDal.Delete(entity);
        }

        public ICollection<CreditCard> GetAll()
        {
            return _creditCardDal.GetAll();
        }

        public CreditCard GetById(int id)
        {
            return _creditCardDal.GetById(cc => cc.CreditCardId == id);
        }

        public ICollection<CreditCard> GetByUserId(int? id)
        {
            return id == null ? _creditCardDal.GetAll() : _creditCardDal.GetAll(a => a.UserId == id);
        }

        public bool Update(CreditCard entity)
        {
            return _creditCardDal.Update(entity);
        }
    }
}
