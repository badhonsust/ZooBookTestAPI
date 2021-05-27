using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ZooBook.Domain.Entities;
using ZooBook.Domain.Enums;
using ZooBook.Domain.Interfaces;
using ZooBook.Infra.Data.DataSeeder;

namespace ZooBook.Infra.Data.Context
{
    public class ZooBookDbContext : DbContext
    {
        public ZooBookDbContext(DbContextOptions<ZooBookDbContext> options)
          : base(options)
        {
        }

        public DbSet<Employee> Employes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Employee>().HasData(EmployeeDataSeeder.SeedData());
            base.OnModelCreating(builder);
        }
      

    }
}
