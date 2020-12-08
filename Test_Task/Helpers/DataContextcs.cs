using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test_Task.Models;

namespace Test_Task.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Name = "Vadym",
                    Age = 22
                },
                new User
                {
                    Id = 2,
                    Name = "Vova",
                    Age = 21
                },
                new User
                {
                    Id = 3,
                    Name = "Kolia",
                    Age = 25
                },
                new User
                {
                    Id = 4,
                    Name = "Vika",
                    Age = 22
                },
                new User
                {
                    Id = 5,
                    Name = "Nastia",
                    Age = 20
                }
                );
        }
    }
}
