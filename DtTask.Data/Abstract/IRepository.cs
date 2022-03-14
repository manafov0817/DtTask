using System.Collections.Generic;

namespace DtTask.Data.Abstract
{
    public interface IGenericRepository<T>
    {
        T GetById(int id);
        ICollection<T> GetAll();
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
