namespace CicekSitesi.DAL.Migrations
{
    using CicekSitesi.Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CicekSitesi.DAL.EntityFramework.CicekSitesiDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CicekSitesi.DAL.EntityFramework.CicekSitesiDbContext context)
        {
            //List<Role> roles = new List<Role>()
            //{
            //    new Role(){RoleName="Yönetici"},
            //    new Role(){RoleName="Kullanıcı"}
            //};
            //context.Roles.AddRange(roles);


            //Person admin = new Person()
            //{
            //    Mail = "tugbaozmen123@gmail.com",
            //    Password = "123qwe",
            //    Name = "Tuğba",
            //    Surname = "ÖZMEN"
            //};
            //PersonRole adminRole = new PersonRole();
            //adminRole.PersonId = admin.PersonId;
            //adminRole.RoleId = 1;
            //context.Persons.Add(admin);
            //context.PersonRoles.Add(adminRole);
            Person person = new Person()
            {
                Mail = "ali@mail.com",
                Password = "123",
                Name = "Ali",
                Surname = "SEVDA"
            };
            context.Persons.Add(person);
            //context.SaveChanges();
        }
    }
}
