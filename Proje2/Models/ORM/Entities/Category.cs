using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models.ORM.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Descripiton { get; set; }
        public string Picture { get; set; }
        public List<Product> Products { get; set; }
    }
}
