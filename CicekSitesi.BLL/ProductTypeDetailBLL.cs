using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
    public class ProductTypeDetailBLL : IBaseService<ProductTypeDetail>
    {
        ProductTypeDetailDAL<ProductTypeDetail> productTypeDetailDAL;

        public ProductTypeDetailBLL()
        {
            productTypeDetailDAL = new ProductTypeDetailDAL<ProductTypeDetail>();
        }

        public bool Add(ProductTypeDetail entity)
        {
            try
            {
                return productTypeDetailDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(ProductTypeDetail entity)
        {
            try
            {
                return productTypeDetailDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProductTypeDetail> GetAll()
        {
            try
            {
                return productTypeDetailDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ProductTypeDetail GetById(int id)
        {
            try
            {
                return productTypeDetailDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(ProductTypeDetail entity)
        {
            try
            {
                return productTypeDetailDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ProductTypeDetail> GetByProductTypeDetailName(string name)
        {
            try
            {
                return productTypeDetailDAL.GetByProductTypeDetailName(name);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public ProductTypeDetail GetProductTypeDetail(int id)
        {
            try
            {
                return productTypeDetailDAL.GetProductTypeDetail(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
