using CicekSitesi.BLL.ShipperHelpers;
using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
   public class ShipperBLL : IBaseService<Shipper>, IShipperHelper
    {
        ShipperDAL<Shipper> shipperDAL;

        public ShipperBLL()
        {
            shipperDAL = new ShipperDAL<Shipper>();
        }
        public bool Add(Shipper entity)
        {
            try
            {
                CheckPhone(entity.Phone);
                return shipperDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CheckPhone(string phone)
        {
            if (phone.Length>11 || phone.Length<11)
            {
                throw new Exception("Telefon numaranızı kontrol ediniz.");
            }
        }

        public bool Delete(Shipper entity)
        {
            try
            {
                return shipperDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Shipper> GetAll()
        {
            try
            {
                return shipperDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Shipper GetById(int id)
        {
            try
            {
                return shipperDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Shipper entity)
        {
            try
            {
                CheckPhone(entity.Phone);
                return shipperDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Shipper> GetByShipperName(string name)
        {
            try
            {
                return shipperDAL.GetByShipperName(name);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Shipper GetShipper(int id)
        {
            try
            {
                return shipperDAL.GetShipper(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
