using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManager.Models;

namespace ProductManager.Data
{
    public class ProductsContext : DbContext
    {
        public ProductsContext(DbContextOptions<ProductsContext> options) :base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
