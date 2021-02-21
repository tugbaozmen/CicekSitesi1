using CicekSitesi.DAL.EntityFramework.Mappings;
using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework
{
    class CicekSitesiDbContext:DbContext
    {
        public CicekSitesiDbContext(): base("name=CicekSitesiConnstr")
        {

        }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PersonDetail> PersonDetails { get; set; }
        public DbSet<PersonRole> PersonRoles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductTypeDetail> ProductTypeDetails { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Shipper> Shippers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new OrderDetailMapping());
            modelBuilder.Configurations.Add(new PersonDetailMapping());
            modelBuilder.Configurations.Add(new PersonMapping());
            modelBuilder.Configurations.Add(new PersonRoleMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new ProductTypeMapping());
            modelBuilder.Configurations.Add(new ProductTypeDetailMapping());
            modelBuilder.Configurations.Add(new RoleMapping());
            modelBuilder.Configurations.Add(new ShipperMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }
    }
}
