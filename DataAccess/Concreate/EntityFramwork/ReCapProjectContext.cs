using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramwork
{
    public class ReCapProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ReCapProject;Trusted_Connection=true");
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Rental> Rental { get; set; }
        public DbSet<User> User { get; set; }

    }
}
