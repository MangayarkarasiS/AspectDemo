using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AspectDemo.Models
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Customer> Customers1 { get; set; }
    }
}
