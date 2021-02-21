using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
    public class Role:BaseEntity
    {
        public Role()
        {
            PersonRoles = new HashSet<PersonRole>();
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }

        //Navigation Prop
        public ICollection<PersonRole> PersonRoles { get; set; }

    }
}
