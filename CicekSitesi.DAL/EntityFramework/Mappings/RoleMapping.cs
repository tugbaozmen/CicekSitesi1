using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class RoleMapping: EntityTypeConfiguration<Role>
    {
        public RoleMapping()
        {
            Property(a => a.RoleName)
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
