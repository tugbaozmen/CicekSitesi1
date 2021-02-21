using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class PersonRoleDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        CicekSitesiDbContext context;
        public PersonRoleDAL()
        {
            context = new CicekSitesiDbContext();
        }

        //public bool Add(PersonRole person)
        //{
        //    context.PersonRoles.Add(person);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(PersonRole person)
        //{
        //    context.Entry(person).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(PersonRole person)
        //{
        //    context.Entry(person).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public PersonRole GetPersonRole(int id)
        {
            return context.PersonRoles.Where(a => a.PersonRoleId == id).FirstOrDefault();
        }
        //public List<PersonRole> GetAllPersonRoles()
        //{
        //    return context.PersonRoles.ToList();
        //}
    }
}
