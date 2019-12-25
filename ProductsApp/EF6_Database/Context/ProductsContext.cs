using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using EF6_Database.Models;

namespace EF6_Database.Context
{
    public class ProductsContext : DbContext
    {
        public ProductsContext() : base("name=ProductsContext")
{
            // New code:
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

        public DbSet<Product> Products { get; set; }
    } // end of
}
