using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public bool Add(User entity)
        {
            try
            {
                //ChekMail(entity.Mail);
                entity.ValidationCode = Guid.NewGuid();
                entity.IsActive = false;
                return _userDal.Add(entity);
            }
            catch (System.Exception)
            {
                throw new Exception();
            }
            //return _userDal.Add(entity);
        }

        public bool Delete(User entity)
        {
            return _userDal.Delete(entity);
        }

        public ICollection<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.GetById(u => u.UserId == id);
        }

        public bool Update(User entity)
        {
            return _userDal.Update(entity);
        }

        public User UserLogin(string mail, string password)
        {
            return _userDal.GetById(u => u.Mail == mail && u.Password == password);
        }
    }
}
