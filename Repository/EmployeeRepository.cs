using GenericRepository.Data;
using GenericRepository.IRepository;
using GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repository
{
    public class EmployeeRepository : IEmployeeRepository

    {
        private readonly ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(Employee entity)
        {
            _db.Employee.Add(entity);
            return Save();
        }

        public bool Delete(Employee entity)
        {
            _db.Employee.Remove(entity);
            return Save();
        }

        public ICollection<Employee> FindAll()
        {
            var Employee = _db.Employee.ToList();
            return Employee;
        }

        public Employee FindById(int id)
        {
            var Employee = _db.Employee.Find(id);
            return Employee;
        }

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Upadate(Employee entity)
        {
            _db.Employee.Update(entity);
            return Save();
        }
    }
}
