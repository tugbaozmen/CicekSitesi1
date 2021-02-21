using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class OrderDetailMapping: EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailMapping()
        {
            Property(a => a.OrderDate)
                  .IsRequired();

            HasRequired(a => a.Product)
                .WithMany(a => a.OrderDetails)
                .HasForeignKey(a => a.ProductId);

            HasRequired(a => a.Order)
                .WithMany(a => a.OrderDetails)
                .HasForeignKey(a => a.OrderId);
        }
    }
}
