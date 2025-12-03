using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsProduct.DB
{
    public class SalesContext: DbContext
    {
        public SalesContext() : base("name=SalesContext")
        {
            Database.SetInitializer<SalesContext>(new DropCreateDatabaseIfModelChanges<SalesContext>());
        }
        public DbSet<Data.Customer> Customers { get; set; }
        public DbSet<Data.Product> Products { get; set; }
        public DbSet<Data.Order> Orders { get; set; }
    }
}
