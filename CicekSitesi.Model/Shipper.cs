using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
   public class Shipper:BaseEntity
    {
        public Shipper()
        {
            Orders = new HashSet<Order>();
        }
        public int ShipperId { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

        //Navigation Prop
        public ICollection<Order> Orders { get; set; }
    }
}
