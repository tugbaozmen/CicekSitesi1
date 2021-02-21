using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class RoleDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        CicekSitesiDbContext context;
        public RoleDAL()
        {
            context = new CicekSitesiDbContext();
        }

        //public bool Add(Role role)
        //{
        //    context.Roles.Add(role);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(Role role)
        //{
        //    context.Entry(role).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(Role role)
        //{
        //    context.Entry(role).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public Role GetRole(int id)
        {
            return context.Roles.Where(a => a.RoleId == id).FirstOrDefault();
        }
        //public List<Role> GetAllRoles()
        //{
        //    return context.Roles.ToList();
        //}
        public List<Role> GetByRoleName(string name)
        {
            return context.Roles.Where(a => a.RoleName == name).ToList();
        }
    }
}
