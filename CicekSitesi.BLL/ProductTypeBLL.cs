using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
    public class ProductTypeBLL:IBaseService<ProductType>
    {
        ProductTypeDAL<ProductType> productTypeDAL;

        public ProductTypeBLL()
        {
            productTypeDAL = new ProductTypeDAL<ProductType>();
        }

        public bool Add(ProductType entity)
        {
            try
            {
                return productTypeDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(ProductType entity)
        {
            try
            {
                return productTypeDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(ProductType entity)
        {
            try
            {
                return productTypeDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ProductType GetById(int id)
        {
            try
            {
                return productTypeDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ProductType> GetAll()
        {
            try
            {
                return productTypeDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductType> GetByProductTypeName(string name)
        {
            try
            {
                return productTypeDAL.GetByProductTypeName(name);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ProductType GetProductType(int id)
        {
            try
            {
                return productTypeDAL.GetProductType(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
