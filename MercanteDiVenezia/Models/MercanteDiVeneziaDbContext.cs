using System.Data.Entity;

namespace MercanteDiVenezia.Models
{
    public class MercanteDiVeneziaDbContext : DbContext
    {
        public MercanteDiVeneziaDbContext() : base()
        {
            Database.SetInitializer<MercanteDiVeneziaDbContext>(new CreateDatabaseIfNotExists<MercanteDiVeneziaDbContext>());
        }
        public virtual DbSet<Customer> Categories { get; set; }
                
        public virtual DbSet<Item> Items { get; set; }

        public void SetModified(object item)
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
