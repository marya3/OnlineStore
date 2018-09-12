using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnLineStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String Category { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
