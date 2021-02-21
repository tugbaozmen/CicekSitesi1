using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class OrderMapping: EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            Property(a => a.RecipientName)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.RecipientSurname)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.SenderName)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.SenderSurname)
                .HasMaxLength(30)
                .IsRequired();

            HasRequired(a => a.Shipper)
                  .WithMany(a => a.Orders)
                  .HasForeignKey(a => a.ShipperId);

            HasRequired(a => a.Person)
                .WithMany(a => a.Orders)
                .HasForeignKey(a => a.PersonId);
        }
    }
}
