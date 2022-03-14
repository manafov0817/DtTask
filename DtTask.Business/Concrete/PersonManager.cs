using DtTask.Business.Abstract;
using DtTask.Data.Abstract;
using DtTask.Entity.Entities;
using System;
using System.Collections.Generic;

namespace DtTask.Business.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonRepository _personRepository;

        public PersonManager(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public bool Create(Person entity)
        {

            return _personRepository.Create(entity);
        }

        public bool CreateWithPersonType(Person person)
        {
            return _personRepository.CreateWithPersonType(person);
        }

        public bool Delete(Person entity)
        {
            return _personRepository.Delete(entity);
        }

        public IEnumerable<Person> GetAll()
        {
            return _personRepository.GetAll();
        }

        public Person GetById(int id)
        {
            return _personRepository.GetById(id);
        }

        public ICollection<Person> GetPeopleIncluded()
        {
            return _personRepository.GetPeopleIncluded();
        }

        public bool IsUniqueUser(string name)
        {
            return _personRepository.IsUniqueUser(name);
        }

        public bool Update(Person entity)
        {
            if (entity.Id == 0)
            {
                throw new Exception("Entity is not valid");
            }
            if (entity.PersonTypeId == 0)
            {
                throw new Exception("Person TypeId is not valid");
            }



            return _personRepository.Update(entity);
        }
    }
}
