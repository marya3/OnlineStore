using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnLineStore.Models;

namespace OnLineStore.Models
{
    public class OnLineStoreContext : DbContext
    {
        public OnLineStoreContext (DbContextOptions<OnLineStoreContext> options)
            : base(options)
        {
        }

        public DbSet<OnLineStore.Models.Customer> Customer { get; set; }

        public DbSet<OnLineStore.Models.Order> Order { get; set; }

        public DbSet<OnLineStore.Models.Product> Product { get; set; }

        public DbSet<OnLineStore.Models.ShoppingCart> ShoppingCart { get; set; }
    }
}
