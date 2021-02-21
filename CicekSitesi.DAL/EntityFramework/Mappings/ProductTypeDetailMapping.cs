using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class ProductTypeDetailMapping: EntityTypeConfiguration<ProductTypeDetail>
    {
        public ProductTypeDetailMapping()
        {
            Property(a => a.TypeDetailName)
                .HasMaxLength(100)
                .IsRequired();

            HasRequired(a => a.ProductType)
                .WithMany(a => a.ProductTypeDetails)
                .HasForeignKey(a => a.ProductTypeId);
        }
    }
}
