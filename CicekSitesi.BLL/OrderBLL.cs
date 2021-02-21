using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
    public class OrderBLL:IBaseService<Order>
    {
        OrderDAL<Order> orderDAL;

        public OrderBLL()
        {
            orderDAL = new OrderDAL<Order>();
        }

        public bool Add(Order order)
        {
            try
            {
                return orderDAL.Add(order)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(Order order)
        {
            try
            {
                return orderDAL.Update(order)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(Order order)
        {
            try
            {
                return orderDAL.Delete(order)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Order GetById(int id)
        {
            try
            {
                return orderDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Order> GetAll()
        {
            try
            {
                return orderDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Order> GetByTotalPrice(decimal totalPrice)
        {
            try
            {
                return orderDAL.GetByTotalPrice(totalPrice);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Order GetOrder(int id)
        {
            try
            {
                return orderDAL.GetOrder(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
