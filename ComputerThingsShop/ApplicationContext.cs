using ComputerThingsShop.Models;
using ComputerThingsShop.Models.ComputerComponents;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerThingsShop
{
    class ApplicationContext : DbContext
    {
        public ApplicationContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }
        public DbSet<ComputerCase> ComputerCases { get; set; }
        public DbSet<CooldownSystem> CooldownSystems { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<GPU> GPUs { get; set; }
        public DbSet<HardDrive> HardDrives { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PowerSupply> PowerSupplies { get; set; }
        public DbSet<RAM> RAMs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
