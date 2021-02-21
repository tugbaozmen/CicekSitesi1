using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
    public class ProductType:BaseEntity
    {
        public ProductType()
        {
            ProductTypeDetails = new HashSet<ProductTypeDetail>();
            Products = new HashSet<Product>();
        }
        public int ProductTypeId { get; set; }
        public string ProductTypeName { get; set; }

        //Navigation Prop
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductTypeDetail> ProductTypeDetails { get; set; }
    }
}
