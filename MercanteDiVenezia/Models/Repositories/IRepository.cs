using System;
using System.Data.Entity;
using System.Linq;

namespace MercanteDiVenezia.Models.Repositories
{
    public interface IRepository<TModel> : IDisposable where TModel : class
    {
        void SaveChanges();

        void SetModified(TModel item);

        DbSet<TModel> GetDbSet();
        IQueryable<TModel> GetData();

        void AddToDbSet(TModel item);

        TModel GetById(int? id);

        void Remove(TModel item);
    }
}
