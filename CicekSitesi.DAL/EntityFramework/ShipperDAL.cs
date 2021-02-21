using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class ShipperDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        CicekSitesiDbContext context;
        public ShipperDAL()
        {
            context = new CicekSitesiDbContext();
        }

        //public bool Add(Shipper shipper)
        //{
        //    context.Shippers.Add(shipper);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(Shipper shipper)
        //{
        //    context.Entry(shipper).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(Shipper shipper)
        //{
        //    context.Entry(shipper).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public Shipper GetShipper(int id)
        {
            return context.Shippers.Where(a => a.ShipperId == id).FirstOrDefault();
        }
        //public List<Shipper> GetAllShippers()
        //{
        //    return context.Shippers.ToList();
        //}
        public List<Shipper> GetByShipperName(string name)
        {
            return context.Shippers.Where(a => a.CompanyName == name).ToList();
        }
    }
}
