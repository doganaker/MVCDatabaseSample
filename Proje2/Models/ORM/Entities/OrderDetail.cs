using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models.ORM.Entities
{
    public class OrderDetail
    {
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
    }
}
