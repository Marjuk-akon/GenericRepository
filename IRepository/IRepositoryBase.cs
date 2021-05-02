using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericRepository.IRepository
{
    public interface IRepositoryBase<T> where T:class
    {
        ICollection<T> FindAll();
        T FindById(int id);
        bool Create(T entity);
        bool Upadate(T entity);
        bool Delete(T entity);
        bool Save();

    }
}
