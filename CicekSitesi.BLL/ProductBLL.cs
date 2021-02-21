using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
    public class ProductBLL:IBaseService<Product>
    {
        ProductDAL<Product> productDAL;

        public ProductBLL()
        {
            productDAL = new ProductDAL<Product>();
        }

        public bool Add(Product product)
        {
            try
            {
                return productDAL.Add(product)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(Product product)
        {
            try
            {
                return productDAL.Update(product)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(Product product)
        {
            try
            {
                return productDAL.Delete(product)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Product GetById(int id)
        {
            try
            {
                return productDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Product> GetAll()
        {
            try
            {
                return productDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product GetByProductName(string name)
        {
            try
            {
                return productDAL.GetByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product GetProduct(int id)
        {
            try
            {
                return productDAL.GetProduct(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
