using System.Collections.Generic;

namespace DtTask.Business.Abstract
{
    public interface IGenericService<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool Create(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
