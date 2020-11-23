using Microsoft.EntityFrameworkCore;
using Proje2.Models.ORM.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje2.Models.ORM.Context
{
    public class TradeNetworkContext : DbContext
    {
        public TradeNetworkContext(DbContextOptions<TradeNetworkContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees{ get; set; }
    }
}
