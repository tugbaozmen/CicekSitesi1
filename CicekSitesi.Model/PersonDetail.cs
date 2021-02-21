using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
   public class PersonDetail:BaseEntity
    {
        public int PersonDetailId { get; set; }
        public int PersonId { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        //Navigation Prop
        public Person Person { get; set; }
    }
}
