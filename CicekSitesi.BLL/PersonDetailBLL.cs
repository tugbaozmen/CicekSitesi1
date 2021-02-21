using CicekSitesi.BLL.PersonHelpers;
using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
    public class PersonDetailBLL:IBaseService<PersonDetail>,IPersonDetailHelper
    {
        PersonDetailDAL<PersonDetail> personDetailDAL;

        public PersonDetailBLL()
        {
            personDetailDAL = new PersonDetailDAL<PersonDetail>();
        }

        public bool Add(PersonDetail personDetail)
        {
            try
            {
                return personDetailDAL.Add(personDetail)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(PersonDetail personDetail)
        {
            try
            {
                return personDetailDAL.Update(personDetail)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(PersonDetail personDetail)
        {
            try
            {
                return personDetailDAL.Delete(personDetail)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PersonDetail GetById(int id)
        {
            try
            {
                return personDetailDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<PersonDetail> GetAll()
        {
            try
            {
                return personDetailDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CheckedPhone(string phone)
        {
            if (phone.Length>11 || phone.Length<11)
            {
                throw new Exception("Lütfen telefon numaranızı kontrol ediniz.");
            }
        }

        public List<PersonDetail> GetByCity(string city)
        {
            try
            {
                return personDetailDAL.GetByCity(city);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PersonDetail GetPersonDetail(int id)
        {
            try
            {
                return personDetailDAL.GetPersonDetail(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
