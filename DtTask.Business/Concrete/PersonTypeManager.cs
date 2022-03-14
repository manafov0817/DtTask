using DtTask.Business.Abstract;
using DtTask.Data.Abstract;
using DtTask.Entity.Entities;
using System.Collections.Generic;

namespace DtTask.Business.Concrete
{
    public class PersonTypeManager : IPersonTypeService
    {
        private IPersonTypeRepository _personTypeRepository;

        public PersonTypeManager(IPersonTypeRepository personTypeRepository)
        {
            _personTypeRepository = personTypeRepository;
        }

        public bool Create(PersonType entity)
        {
            return _personTypeRepository.Create(entity);
        }

        public bool Delete(PersonType entity)
        {
            return _personTypeRepository.Delete(entity);
        }

        public IEnumerable<PersonType> GetAll()
        {
            return _personTypeRepository.GetAll();
        }

        public PersonType GetById(int id)
        {
            return _personTypeRepository.GetById(id);
        }

        public ICollection<PersonType> GetPersonTypesByNumber(string word, int number)
        {
            return _personTypeRepository.GetPersonTypesByNumber(word, number);
        }

        public bool Update(PersonType entity)
        {
            return _personTypeRepository.Update(entity);
        }
    }
}
