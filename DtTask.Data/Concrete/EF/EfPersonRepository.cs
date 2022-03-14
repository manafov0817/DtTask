using DtTask.Data.Abstract;
using DtTask.Entity.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace DtTask.Data.Concrete.EF
{
    public class EfPersonRepository : EfGenericRepository<Person, DtTaskDbContext>, IPersonRepository
    {
        public bool CreateWithPersonType(Person person)
        {
            using (var context = new DtTaskDbContext())
            {

                bool predicate = context.PersonTypes.Where(pt => pt.Name.ToLower() ==
                                                                 person.PersonType.Name.ToLower()).Any();

                if (predicate)
                {
                    person.PersonType = context.PersonTypes
                                                    .Where(p => p.Name.ToLower() == person.PersonType.Name.ToLower())
                                                    .FirstOrDefault();
                }

                context.People.Add(person);

                DtTaskDbContext context1 = context;
                return context1.SaveChanges() > 0 ? true : false;
            }
        }

        public ICollection<Person> GetPeopleIncluded()
        {
            using (var context = new DtTaskDbContext())
            {
                return context.People.Include(p => p.PersonType).OrderByDescending(p => p.Id).ToList();
            }
        }
        public bool IsUniqueUser(string name)
        {
            using (var context = new DtTaskDbContext())
            {
                return !context.People
                              .Any(p => p.Name == name);
            }
        }
    }
}
