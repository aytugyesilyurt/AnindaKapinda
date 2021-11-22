using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;

        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public bool Add(Employee entity)
        {
            return _employeeDal.Add(entity);
        }

        public bool Delete(Employee entity)
        {
            return _employeeDal.Delete(entity);
        }

        public ICollection<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public Employee GetById(int id)
        {
            return _employeeDal.GetById(e => e.EmployeeId == id);
        }

        public bool Update(Employee entity)
        {
            return _employeeDal.Update(entity);
        }
    }
}
