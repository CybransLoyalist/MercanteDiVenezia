using System.Data.Entity;
using System.Linq;

namespace MercanteDiVenezia.Models.Repositories
{
    public abstract class Repository<TModel> : IRepository<TModel> where TModel : class
    {
        protected readonly MercanteDiVeneziaDbContext Db;

        protected Repository(MercanteDiVeneziaDbContext db)
        {
            Db = db;
        }

        public virtual void SaveChanges()
        {
            Db.SaveChanges();
        }

        public virtual void SetModified(TModel item)
        {
            Db.SetModified(item);
        }

        public virtual TModel GetById(int? id)
        {
            return GetDbSet().Find(id);
        }

        public virtual void Remove(TModel item)
        {
            GetDbSet().Remove(item);
        }

        public abstract DbSet<TModel> GetDbSet();

        public virtual IQueryable<TModel> GetData()
        {
            return GetDbSet();
        }

        public virtual void AddToDbSet(TModel item)
        {
            GetDbSet().Add(item);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}