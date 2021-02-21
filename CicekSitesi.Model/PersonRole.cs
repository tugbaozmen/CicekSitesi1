using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
    public class PersonRole:BaseEntity
    {
        public int PersonRoleId { get; set; }
        public int PersonId { get; set; }
        public int RoleId { get; set; }

        //Navigation Prop
        public Person Person { get; set; }
        public Role Role { get; set; }
    }
}
