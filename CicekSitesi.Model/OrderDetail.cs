using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
    public class OrderDetail:BaseEntity
    {

        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        //Navigation Prop
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
