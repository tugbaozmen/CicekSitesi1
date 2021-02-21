using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class OrderDetailDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        CicekSitesiDbContext context;
        public OrderDetailDAL()
        {
            context = new CicekSitesiDbContext();
        }
        //public bool Add(OrderDetail order)
        //{
        //    context.OrderDetails.Add(order);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(OrderDetail order)
        //{
        //    context.Entry(order).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(OrderDetail order)
        //{
        //    context.Entry(order).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public OrderDetail GetOrderDetail(int id)
        {
            return context.OrderDetails.SingleOrDefault(a => a.OrderDetailId == id);
        }
        //public List<OrderDetail> GetAllOrderDetails()
        //{
        //    return context.OrderDetails.ToList();
        //}
        public List<OrderDetail> GetByDateOrderDetail(DateTime dateTime)
        {
            return context.OrderDetails.Where(a => a.OrderDate == dateTime).ToList();
        }
    }
}
