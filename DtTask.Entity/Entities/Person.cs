using System.ComponentModel.DataAnnotations;

namespace DtTask.Entity.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public int PersonTypeId { get; set; }
        public PersonType PersonType { get; set; }
    }
}
