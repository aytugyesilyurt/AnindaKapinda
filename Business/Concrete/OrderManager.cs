using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public bool Add(Order entity)
        {
            return _orderDal.Add(entity);
        }

        public bool Delete(Order entity)
        {
            return _orderDal.Delete(entity);
        }

        public ICollection<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderDal.GetById(o => o.OrderId == id);
        }

        public ICollection<Order> GetByUserId(int? id)
        {
            return id == null ? _orderDal.GetAll() : _orderDal.GetAll(a => a.UserId == id);
        }

        public bool Update(Order entity)
        {
            return _orderDal.Update(entity);
        }
    }
}
