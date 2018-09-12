using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetailStore.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Street { get; set; }
        public int ZipCode { get; set; }
        public String City { get; set; }
        public String Email { get; set; }
    }
}
