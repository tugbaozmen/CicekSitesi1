using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class OrderDAL<TEntity>:BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        //DbSet<TEntity> entities;
        CicekSitesiDbContext context;
        public OrderDAL()
        {
            context = new CicekSitesiDbContext();
            //entities = context.Set<TEntity>();
        }


        //public bool Add(TEntity entity)
        //{
        //    entities.Add(entity);
        //    return context.SaveChanges() > 0;
        //}

        //public bool Update(TEntity entity)
        //{
        //    context.Entry(entity).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}

        //public bool Delete(TEntity entity)
        //{
        //    entities.Remove(entity);
        //    return context.SaveChanges() > 0;

        //}

        //public TEntity Get(int id)
        //{
        //    return entities.SingleOrDefault();
        //}

        //public ICollection<TEntity> GetAll()
        //{
        //    return entities.ToList();
        //}


        //public bool Add(Order order)
        //{
        //    context.Orders.Add(order);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(Order order)
        //{
        //    context.Entry(order).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(Order order)
        //{
        //    context.Entry(order).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public Order GetOrder(int id)
        {
            return context.Orders.SingleOrDefault(a => a.OrderId == id);
        }

        //public List<Order> GetAllOrder()
        //{
        //    return context.Orders.ToList();
        //}

        public List<Order> GetByTotalPrice(decimal totalPrice)
        {
            return context.Orders.Where(a => a.TotalPrice == totalPrice).ToList();
        }
    }
}
