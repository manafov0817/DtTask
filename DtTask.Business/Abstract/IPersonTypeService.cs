using DtTask.Entity.Entities;
using System.Collections.Generic;

namespace DtTask.Business.Abstract
{
    public interface IPersonTypeService : IGenericService<PersonType>
    {
        ICollection<PersonType> GetPersonTypesByNumber(string word, int number);
    }
}

