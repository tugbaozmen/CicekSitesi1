using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicekSitesi.Model
{
    public class Product:BaseEntity
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }

        [Required(ErrorMessage = "Ürün Adı boş geçilemez")]
        [DisplayName("Ürün Adı")]
        [MinLength(5, ErrorMessage = "Ad alanı en az {1} karakter içermelidir")]
        [MaxLength(100)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Ürün Açıklaması boş geçilemez")]
        [DisplayName("Ürün Açıklaması")]
        [MaxLength(100)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Ürün fiyatı boş geçilemez")]
        [DisplayName("Fiyat")]
        public decimal UnitPrice { get; set; }

        [Required(ErrorMessage = "Ürün stok bilgisi boş geçilemez")]
        [DisplayName("Stok")]
        public int UnitsInStock { get; set; }
        public byte[] Photo { get; set; }

        //Navigation Prop
        public ProductType ProductType { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
