using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
    public class Order:BaseEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int OrderId { get; set; }
        public int ShipperId { get; set; }
        public int PersonId { get; set; }
        public string RecipientName { get; set; } //Alıcı
        public string RecipientSurname { get; set; }
        public string SenderName { get; set; } //Gönderici
        public string SenderSurname { get; set; }
        public decimal TotalPrice { get; set; }

        //Navigation Prop
        public Shipper Shipper { get; set; }
        public Person Person { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
