using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class BaseDAL<TEntity> : IBase<TEntity>
         where TEntity : BaseEntity
    {
        DbSet<TEntity> entities;
        CicekSitesiDbContext context;
        public BaseDAL()
        {
            context = new CicekSitesiDbContext();
            entities = context.Set<TEntity>();
        }


        public int Add(TEntity entity)
        {
            entities.Add(entity);
            return context.SaveChanges();
        }

        public int Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            return context.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return context.SaveChanges();

        }

        public TEntity Get(int id)
        {
            return entities.FirstOrDefault();
        }

        public ICollection<TEntity> GetAll()
        {
            return entities.ToList();
        }

    }
}
