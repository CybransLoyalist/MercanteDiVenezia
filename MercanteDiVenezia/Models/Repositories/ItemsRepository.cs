using System.Data.Entity;

namespace MercanteDiVenezia.Models.Repositories
{
    public class ItemsRepository : Repository<Item>
    {
        public ItemsRepository(MercanteDiVeneziaDbContext db) : base(db)
        {
        }

        public override DbSet<Item> GetDbSet()
        {
            return Db.Items;
        }
    }
}