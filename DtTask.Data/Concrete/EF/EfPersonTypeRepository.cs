using DtTask.Data.Abstract;
using DtTask.Entity.Entities;
using System.Collections.Generic;
using System.Linq;

namespace DtTask.Data.Concrete.EF
{
    public class EfPersonTypeRepository : EfGenericRepository<PersonType, DtTaskDbContext>, IPersonTypeRepository
    {
        public ICollection<PersonType> GetPersonTypesByNumber(string word, int number)
        {
            using (var context = new DtTaskDbContext())
            {
                return context.PersonTypes.Where(pt => pt.Name.ToLower()
                                                              .Contains(word.ToLower()))
                                          .Take(number)
                                          .ToList();
            }
        }
    }
}
