using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Ivanna.Models
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext()
        : base("default")
        {
        }

        public System.Data.Entity.DbSet<Ivanna.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<Ivanna.Models.Customer> Customers { get; set; }
    }
}