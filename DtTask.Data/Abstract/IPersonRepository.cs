using DtTask.Entity.Entities;
using System.Collections.Generic;

namespace DtTask.Data.Abstract
{
    public interface IPersonRepository : IGenericRepository<Person>
    {
        ICollection<Person> GetPeopleIncluded();
        bool IsUniqueUser(string name);
        bool CreateWithPersonType(Person person);
    }
}
