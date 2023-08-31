using FactoryCSharp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FactoryCSharp.DbContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Machine> Machines { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<CycleOperation> CycleOperations { get; set; }
        public DbSet<ProductionCycle> ProductionCycles { get; set; }

    }
}
