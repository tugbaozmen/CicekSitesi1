using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    public class PersonDAL<TEntity> : BaseDAL<TEntity>, IBase<TEntity>
         where TEntity : BaseEntity
    {

        //DbSet<TEntity> entities;
        CicekSitesiDbContext context;
        public PersonDAL()
        {
            context = new CicekSitesiDbContext();
            //entities = context.Set<TEntity>();
        }
        //public bool Add(TEntity entity)
        //{
        //    entities.Add(entity);
        //    return context.SaveChanges() > 0;
        //}

        //public bool Update(TEntity entity)
        //{
        //    context.Entry(entity).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}

        //public bool Delete(TEntity entity)
        //{
        //    entities.Remove(entity);
        //    return context.SaveChanges() > 0;

        //}

        //public TEntity Get(int id)
        //{
        //    return entities.SingleOrDefault();
        //}

        //public ICollection<TEntity> GetAll()
        //{
        //    return entities.ToList();
        //}

        //public bool Add(Person person)
        //{
        //    context.Persons.Add(person);
        //    return context.SaveChanges() > 0;
        //}
        //public bool Update(Person person)
        //{
        //    context.Entry(person).State = EntityState.Modified;
        //    return context.SaveChanges() > 0;
        //}
        //public bool Delete(int id)
        //{
        //    Person person = context.Persons.Find(id);
        //    context.Entry(person).State = EntityState.Deleted;
        //    return context.SaveChanges() > 0;
        //}
        public Person GetPerson(int id)
        {
            return context.Persons.Where(a => a.PersonId == id).FirstOrDefault();
        }
        //public List<Person> GetAllPerson()
        //{
        //    return context.Persons.ToList();
        //}
        public Person GetByName(string name)
        {
            return context.Persons.Where(a => a.Name == name).SingleOrDefault();
        }
    }
}
