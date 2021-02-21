using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class PersonDetailMapping: EntityTypeConfiguration<PersonDetail>
    {
        public PersonDetailMapping()
        {
            Property(a => a.Address)
                .HasMaxLength(500)
                .IsRequired();
            Property(a => a.City)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.District)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.Phone)
                .HasMaxLength(11)
                .IsRequired();

            HasRequired(a => a.Person)
                .WithMany(a => a.PersonDetails)
                .HasForeignKey(a => a.PersonId);
        }
    }
}
