using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using paintcompanyrepository.Model;


namespace paintcompanyrepository.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Factory> Factorys { get; set; }
        public DbSet<SolventBasedPaint> SolventBasedPaints { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<WaterBasedPaint> WaterBasedPaints { get; set; }

    }
    
}
