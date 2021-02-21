using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class ProductTypeMapping: EntityTypeConfiguration<ProductType>
    {
        public ProductTypeMapping()
        {
            Property(a => a.ProductTypeName)
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
