using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Poc.Models;

namespace Poc.Dal
{
    public class PocDbContext : DbContext
    {
        public PocDbContext()
        {
        }

        public PocDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=PocDb; Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    EmployeeId = 1,
                    Address = "Cuenca",
                    Avatar = "",
                    City = "Guayaquil",
                    Country = "Ecuador",
                    Email = "roberto@mail.com",
                    EmployeeName = "Roberto el malo",
                    Phone = "0962089555",
                    Skillsets = "C# as fuck",
                    ZipCode = "09101"
                }, new Employee()
                {
                    EmployeeId = 2,
                    Address = "Cuenca",
                    Avatar = "",
                    City = "Guayaquil",
                    Country = "Ecuador",
                    Email = "roberto@mail.com",
                    EmployeeName = "Roberto el bueno",
                    Phone = "0962089555",
                    Skillsets = "C# as fuck",
                    ZipCode = "09101"
                },
                new Employee()
                {
                    EmployeeId = 3,
                    Address = "Cuenca",
                    Avatar = "",
                    City = "Guayaquil",
                    Country = "Ecuador",
                    Email = "roberto@mail.com",
                    EmployeeName = "Roberto el feo",
                    Phone = "0962089555",
                    Skillsets = "C# as fuck",
                    ZipCode = "09101"
                });
            modelBuilder.Entity<Role>()
                .HasData(new Role() { RoleId = 1, RoleName = "Employee", RoleDescription = "Empleado whatever" },
                    new Role() { RoleId = 2, RoleName = "HR", RoleDescription = "CEO" });
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Event> Events { get; set; }
    }
}