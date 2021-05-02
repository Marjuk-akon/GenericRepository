using GenericRepository.Data;
using GenericRepository.IRepository;
using GenericRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveTypeRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveType entity)
        {
            _db.LeaveType.Add(entity);
            return Save();
        }

        public bool Delete(LeaveType entity)
        {
            _db.LeaveType.Remove(entity);
            return Save();
        }

        public ICollection<LeaveType> FindAll()
        {
            var leavetype = _db.LeaveType.ToList();
            return leavetype;
        }

        public LeaveType FindById(int id)
        {
            var leavetype = _db.LeaveType.Find(id);
            return leavetype;
        }      

        public bool Save()
        {
            var changes = _db.SaveChanges();
            return changes > 0;
        }

        public bool Upadate(LeaveType entity)
        {
            _db.LeaveType.Update(entity);
            return Save();
        }
        public ICollection<LeaveType> GetLeaveTypeByLeaveTypeId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
