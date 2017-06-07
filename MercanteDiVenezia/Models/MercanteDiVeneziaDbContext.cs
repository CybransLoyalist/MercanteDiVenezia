using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercanteDiVenezia.Models
{
    class MercanteDiVeneziaDbContext : DbContext
    {
        public MercanteDiVeneziaDbContext() : base()
        {
            Database.SetInitializer<MercanteDiVeneziaDbContext>(new CreateDatabaseIfNotExists<MercanteDiVeneziaDbContext>());
        }
        public DbSet<Customer> Categories { get; set; }

        public DbSet<Item> Items { get; set; }
    }
}
