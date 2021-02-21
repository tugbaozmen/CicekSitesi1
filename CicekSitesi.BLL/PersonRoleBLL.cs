using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
    public class PersonRoleBLL:IBaseService<PersonRole>
    {
        PersonRoleDAL<PersonRole> personRoleDAL;

        public PersonRoleBLL()
        {
            personRoleDAL = new PersonRoleDAL<PersonRole>();
        }

        public bool Add(PersonRole personRole)
        {
            try
            {
                personRole.RoleId = 2;
                return personRoleDAL.Add(personRole)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Update(PersonRole personRole)
        {
            try
            {
                return personRoleDAL.Update(personRole)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Delete(PersonRole personRole)
        {
            try
            {
                return personRoleDAL.Delete(personRole)>0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PersonRole GetById(int id)
        {
            try
            {
                return personRoleDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<PersonRole> GetAll()
        {
            try
            {
                return personRoleDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public PersonRole GetPersonRole(int id)
        {
            try
            {
                return personRoleDAL.GetPersonRole(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
