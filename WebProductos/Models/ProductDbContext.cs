using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebProductos.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("KeyProducts") { }
        public DbSet<Product> Products { get; set; }
    }
}