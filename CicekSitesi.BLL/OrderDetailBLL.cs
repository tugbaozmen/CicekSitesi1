using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
    public class OrderDetailBLL:IBaseService<OrderDetail>
    {
        OrderDetailDAL<OrderDetail> orderDetailDAL;

        public OrderDetailBLL()
        {
            orderDetailDAL = new OrderDetailDAL<OrderDetail>();
        }

        public bool Add(OrderDetail orderDetail)
        {
            try
            {
                return orderDetailDAL.Add(orderDetail)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(OrderDetail orderDetail)
        {
            try
            {
                return orderDetailDAL.Update(orderDetail)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(OrderDetail orderDetail)
        {
            try
            {
                return orderDetailDAL.Delete(orderDetail)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public OrderDetail GetById(int id)
        {
            try
            {
                return orderDetailDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<OrderDetail> GetAll()
        {
            try
            {
                return orderDetailDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<OrderDetail> GetByDateOrderDetail(DateTime date)
        {
            try
            {
                return orderDetailDAL.GetByDateOrderDetail(date);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OrderDetail GetOrderDetail(int id)
        {
            try
            {
                return orderDetailDAL.GetOrderDetail(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
