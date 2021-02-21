using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class ProductMapping: EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            Property(a => a.ProductName)
                .HasMaxLength(100)
                .IsRequired();
            Property(a => a.Description)
                .HasMaxLength(200)
                .IsOptional();
            Property(a => a.UnitPrice)
                .IsRequired();
            Property(a => a.UnitsInStock)
                .IsRequired();

            HasRequired(a => a.ProductType)
                .WithMany(a => a.Products)
                .HasForeignKey(a => a.ProductTypeId);
        }
    }
}
