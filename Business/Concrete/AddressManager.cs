using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class AddressManager : IAddressService
    {
        IAddressDal _adressDal;

        public AddressManager(IAddressDal adressDal)
        {
            _adressDal = adressDal;
        }

        public bool Add(Address entity)
        {
            return _adressDal.Add(entity);
        }

        public bool Delete(Address entity)
        {
            return _adressDal.Delete(entity);
        }

        public ICollection<Address> GetAll()
        {
            return _adressDal.GetAll();
        }

        public Address GetById(int id)
        {
            return _adressDal.GetById(a => a.AddressId == id);
        }

        public ICollection<Address> GetByUserId(int? id)
        {
            return id == null ? _adressDal.GetAll() : _adressDal.GetAll(a => a.UserId == id);
        }

        public bool Update(Address entity)
        {
            return _adressDal.Add(entity);
        }
    }
}
