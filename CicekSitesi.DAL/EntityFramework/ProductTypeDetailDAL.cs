using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class ProductTypeDetailDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        CicekSitesiDbContext context;
        public ProductTypeDetailDAL()
        {
            context = new CicekSitesiDbContext();
        }

        //public bool Add(ProductTypeDetail product)
        //{
        //    context.ProductTypeDetails.Add(product);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(ProductTypeDetail product)
        //{
        //    context.Entry(product).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(int id)
        //{
        //    ProductTypeDetail product = context.ProductTypeDetails.Find(id);
        //    context.Entry(product).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public ProductTypeDetail GetProductTypeDetail(int id)
        {
            return context.ProductTypeDetails.Where(a => a.ProductTypeDetailId == id).FirstOrDefault();
        }
        //public List<ProductTypeDetail> GetAllProductTypeDetails()
        //{
        //    return context.ProductTypeDetails.ToList();
        //}
        public List<ProductTypeDetail> GetByProductTypeDetailName(string name)
        {
            return context.ProductTypeDetails.Where(a => a.TypeDetailName == name).ToList();
        }
    }
}
