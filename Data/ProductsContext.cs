using Everis.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Everis.Data
{
    public class ProductsContext : DbContext
    {       
        public ProductsContext()
        {
        }

        public ProductsContext(DbContextOptions<ProductsContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<SpreadsheetEntry> SpreadsheetEntries { get; set; }
        public DbSet<Inconsistency> Inconsistencies { get; set; }
    }
}
