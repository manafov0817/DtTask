using DtTask.Entity.Entities;
using System.Collections.Generic;

namespace DtTask.Data.Abstract
{
    public interface IPersonTypeRepository : IGenericRepository<PersonType>
    {
        ICollection<PersonType> GetPersonTypesByNumber(string word, int number);
    }

}
