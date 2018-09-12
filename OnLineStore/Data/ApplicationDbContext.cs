using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RetailStore.Models;

namespace OnlineStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<RetailStore.Models.Customer> Customer { get; set; }
        public DbSet<RetailStore.Models.Product> Product { get; set; }
    }
}
