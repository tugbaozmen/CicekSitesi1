using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class PersonMapping: EntityTypeConfiguration<Person>
    {
        public PersonMapping()
        {
            Property(a => a.Mail)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.Name)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.Surname)
                .HasMaxLength(30)
                .IsRequired();
            Property(a => a.Password)
                .HasMaxLength(10)
                .IsRequired();
        }
    }
}
