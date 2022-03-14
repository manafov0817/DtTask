namespace DtTask.Data.Migrations
{
    using DtTask.Entity.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DtTask.Data.Concrete.EF.DtTaskDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DtTask.Data.Concrete.EF.DtTaskDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //

            PersonType personType1 = new PersonType
            {
                Name = "Programmer"
            };
            PersonType personType2 = new PersonType
            {
                Name = "Builder"
            };
            PersonType personType3 = new PersonType
            {
                Name = "Police"
            };
            PersonType personType4 = new PersonType
            {
                Name = "Officer"
            };
            PersonType personType5 = new PersonType
            {
                Name = "Worker"
            };
            PersonType personType6 = new PersonType
            {
                Name = "Medical"
            };
            PersonType personType7 = new PersonType
            {
                Name = "Firefighter"
            };
            PersonType personType8 = new PersonType
            {
                Name = "Engineer"
            };
            PersonType personType9 = new PersonType
            {
                Name = "Manager"
            };

            context.PersonTypes.AddOrUpdate(
                personType1,
                personType2,
                personType3,
                personType4,
                personType5,
                personType6,
                personType7,
                personType8,
                personType9);

            context.People.AddOrUpdate(

              new Person { Name = "Ivan" , PersonType=personType1},
              new Person { Name = "Petr", PersonType=personType2 },
              new Person { Name = "Vailiy", PersonType = personType3 },
              new Person { Name = "Kolia", PersonType = personType4 },
              new Person { Name = "George", PersonType = personType5 },
              new Person { Name = "Olga", PersonType = personType6 },
              new Person { Name = "Aria", PersonType = personType7 },
              new Person { Name = "Aleksandr", PersonType = personType8 },
              new Person { Name = "Nadezhda", PersonType = personType9 },
              new Person { Name = "Anatolyi", PersonType = personType1 },
              new Person { Name = "Lyubov", PersonType = personType3 },
              new Person { Name = "Nyna", PersonType = personType5 },
              new Person { Name = "Ekateryna", PersonType = personType3 },
              new Person { Name = "Vera", PersonType = personType4 },
              new Person { Name = "Dmytryi", PersonType = personType7 },
              new Person { Name = "Aleksei", PersonType = personType8 },
              new Person { Name = "Vytalyi", PersonType = personType9 },
              new Person { Name = "Evhenyi", PersonType = personType4 },
              new Person { Name = "Andrew", PersonType = personType2 },
              new Person { Name = "Brice", PersonType = personType1 },
              new Person { Name = "Rowan", PersonType = personType5 }
            );

        }
    }
}
