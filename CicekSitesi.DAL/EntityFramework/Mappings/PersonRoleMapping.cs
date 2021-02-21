using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class PersonRoleMapping: EntityTypeConfiguration<PersonRole>
    {
        public PersonRoleMapping()
        {
            HasRequired(a => a.Person)
                .WithMany(a => a.PersonRoles)
                .HasForeignKey(a => a.PersonId);

            HasRequired(a => a.Role)
                .WithMany(a => a.PersonRoles)
                .HasForeignKey(a => a.RoleId);
        }
    }
}
