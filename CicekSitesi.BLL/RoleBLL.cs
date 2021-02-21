using CicekSitesi.DAL.EntityFramework;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.BLL
{
   public class RoleBLL : IBaseService<Role>
    {
        RoleDAL<Role> roleDAL;

        public RoleBLL()
        {
            roleDAL = new RoleDAL<Role>();
        }
        public bool Add(Role entity)
        {
            try
            {
                return roleDAL.Add(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(Role entity)
        {
            try
            {
                return roleDAL.Delete(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Role> GetAll()
        {
            try
            {
                return roleDAL.GetAll().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Role GetById(int id)
        {
            try
            {
                return roleDAL.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Update(Role entity)
        {
            try
            {
                return roleDAL.Update(entity) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Role> GetByRoleName(string name)
        {
            try
            {
                return roleDAL.GetByRoleName(name);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Role GetRole(int id)
        {
            try
            {
                return roleDAL.GetRole(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
