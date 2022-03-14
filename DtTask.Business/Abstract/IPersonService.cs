using DtTask.Entity.Entities;
using System.Collections.Generic;

namespace DtTask.Business.Abstract
{
    public interface IPersonService : IGenericService<Person> {
        ICollection<Person> GetPeopleIncluded();
        bool CreateWithPersonType(Person person);
        bool IsUniqueUser(string name);
    }
}
