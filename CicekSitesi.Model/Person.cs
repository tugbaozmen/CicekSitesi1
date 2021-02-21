using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
    public class Person:BaseEntity
    {
        public Person()
        {
            PersonDetails =new HashSet<PersonDetail>();
            Orders = new HashSet<Order>();
            PersonRoles = new HashSet<PersonRole>();
        }
        public int PersonId { get; set; }

        [Required(ErrorMessage = "İsim alanı boş geçilemez")]
        [DisplayName("İsim")]
        [MinLength(3, ErrorMessage = "İsim alanı en az {1} karakter içermelidir")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim alanı boş geçilemez")]
        [DisplayName("Soyisim")]
        [MaxLength(30)]
        public string Surname { get; set; }

        [EmailAddress]
        public string Mail { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        //Navigation Prop
        public ICollection<PersonDetail> PersonDetails { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<PersonRole> PersonRoles { get; set; }
    }
}
