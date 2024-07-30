using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceServiceLibrary
{
    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext() : base("name=ECommerceDatabase")
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
