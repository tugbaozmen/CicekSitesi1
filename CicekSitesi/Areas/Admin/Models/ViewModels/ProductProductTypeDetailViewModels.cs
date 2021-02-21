using CicekSitesi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CicekSitesi.Areas.Admin.Models.ViewModels
{
    public class ProductProductTypeDetailViewModels
    {
        public int ProductId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductTypeDetailId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public byte[] Photo { get; set; }
        public string TypeDetailName { get; set; }
        public string ProductTypeName { get; set; }
    }
}