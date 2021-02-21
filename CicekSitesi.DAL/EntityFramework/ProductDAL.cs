using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class ProductDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        CicekSitesiDbContext context;
        public ProductDAL()
        {
            context = new CicekSitesiDbContext();
        }

        //public bool Add(Product product)
        //{
        //    context.Products.Add(product);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(Product product)
        //{
        //    context.Entry(product).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(Product product)
        //{
        //    context.Entry(product).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}

        public Product GetProduct(int id)
        {
            return context.Products.SingleOrDefault(a => a.ProductId == id);
        }

        //public List<Product> GetAllProduct()
        //{
        //    return context.Products.ToList();
        //}

        public Product GetByName(string name)
        {
            return context.Products.SingleOrDefault(a => a.ProductName == name);
        }
    }
}
