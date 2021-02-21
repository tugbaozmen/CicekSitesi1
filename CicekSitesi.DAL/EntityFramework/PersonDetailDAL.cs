using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class PersonDetailDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {
        CicekSitesiDbContext context;
        public PersonDetailDAL()
        {
            context = new CicekSitesiDbContext();
        }

        //public bool Add(PersonDetail person)
        //{
        //    context.PersonDetails.Add(person);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(PersonDetail person)
        //{
        //    context.Entry(person).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(int id)
        //{
        //    PersonDetail person = context.PersonDetails.Find(id);
        //    context.Entry(person).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public PersonDetail GetPersonDetail(int id)
        {
            return context.PersonDetails.Where(a => a.PersonDetailId == id).FirstOrDefault();
        }
        //public List<PersonDetail> GetAllPersonDetails()
        //{
        //    return context.PersonDetails.ToList();
        //}
        public List<PersonDetail> GetByCity(string city)
        {
            return context.PersonDetails.Where(a => a.City == city).ToList();
        }
    }
}
