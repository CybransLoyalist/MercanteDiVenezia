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
        public DbSet<Customer> Categories { get; set; }
    }
}
