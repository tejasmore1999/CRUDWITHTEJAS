using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUDwithCFA.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("Test")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

      
    }
}