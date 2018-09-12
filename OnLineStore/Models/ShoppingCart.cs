using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnLineStore.Models
{
    public class ShoppingCart
    {
        public int ShoppingCartID { get; set; }
        public int CustomerId { get; set; }
        public List<Product> Products { get; set; }
        public decimal Amount { get; set; }
    }
}
