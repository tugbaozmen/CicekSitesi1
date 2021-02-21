using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
    public class ProductTypeDetail:BaseEntity
    {
        public int ProductTypeDetailId { get; set; }
        public int ProductTypeId { get; set; }
        public string TypeDetailName { get; set; }

        //Navigation Prop
        public ProductType ProductType { get; set; }
    }
}
