﻿using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.DAL.EntityFramework.Mappings
{
    class ShipperMapping: EntityTypeConfiguration<Shipper>
    {
        public ShipperMapping()
        {
            Property(a => a.CompanyName)
                .HasMaxLength(50)
                .IsRequired();
            Property(a => a.Phone)
                .HasMaxLength(11)
                .IsRequired();
        }
    }
}
