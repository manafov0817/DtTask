using DtTask.Entity.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DtTask.Data.Concrete.EF
{
    public class DtTaskDbContext : DbContext
    {
        static string connString = "Data Source = BLACK-DRAGON; Initial Catalog = DtTaskDbContext; Trusted_Connection=True;";

        public DtTaskDbContext() : base(connString) { }

        public DbSet<PersonType> PersonTypes { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
