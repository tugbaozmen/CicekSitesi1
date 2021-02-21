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
    public class PersonBLL:IBaseService<Person>,IPersonHelper
    {
        PersonDAL<Person> personDAL;

        public PersonBLL()
        {
            personDAL = new PersonDAL<Person>();
        }

        public bool Add(Person person)
        {
            try
            {
                CheckedPassword(person.Password);
                person.IsActive = false;
                return personDAL.Add(person)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(Person person)
        {
            try
            {
                CheckedPassword(person.Password);
                return personDAL.Update(person)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(Person person)
        {
            try
            {
                return personDAL.Delete(person)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Person GetById(int id)
        {
            try
            {
                return personDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Person> GetAll()
        {
            try
            {
                return personDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CheckedPassword(string password)
        {
            if (password.Length>10)
            {
                throw new Exception("Şifreniz 10 karakterden daha uzun olamaz. Lütfen kontrol ediniz.");
            }
        }

        public Person GetByName(string name)
        {
            try
            {
                return personDAL.GetByName(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Person GetPerson(int id)
        {
            try
            {
                return personDAL.GetPerson(id);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
