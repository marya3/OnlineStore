using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailStore.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public String Status { get; set; }
        public List<Product> OrderedProducts { get; set; }
    }
}
