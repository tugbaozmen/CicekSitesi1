using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class ProductTypeDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        CicekSitesiDbContext context;
        public ProductTypeDAL()
        {
            context = new CicekSitesiDbContext();
        }

        //public bool Add(ProductType product)
        //{
        //    context.ProductTypes.Add(product);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(ProductType product)
        //{
        //    context.Entry(product).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(ProductType product)
        //{
        //    context.Entry(product).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public ProductType GetProductType(int id)
        {
            return context.ProductTypes.Where(a => a.ProductTypeId == id).FirstOrDefault();
        }
        //public List<ProductType> GetAllProductTypes()
        //{
        //    return context.ProductTypes.ToList();
        //}
        public List<ProductType> GetByProductTypeName(string name)
        {
            return context.ProductTypes.Where(a => a.ProductTypeName == name).ToList();
        }
    }
}
