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

        public DbSet<Book> Books { get; set; }

        public DbSet<Phone> Phones { get; set; }

        public DbSet<Table> Tables { get; set; }

        public DbSet<Tree> Trees { get; set; }

        public DbSet<Window> Windows { get; set; }

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
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Kobzar",
                    NumberOfPages = 432
                }
                );
            modelBuilder.Entity<Phone>().HasData(
                new Phone
                {
                    Id = 1,
                    ManufacturerName = "Apple",
                    Model = "Iphone 7"
                },
                new Phone
                {
                    Id = 2,
                    ManufacturerName = "Samsung",
                    Model = "Galaxy S8"
                }
                );
            modelBuilder.Entity<Table>().HasData(
                new Table
                {
                    Id = 1,
                    Name = "Drawing table",
                    Height = 140
                }
                );
            modelBuilder.Entity<Tree>().HasData(
                new Tree
                {
                    Id = 1,
                    Kind = "Oak",
                    Age = 73
                },
                new Tree
                {
                    Id = 2,
                    Kind = "Birch",
                    Age = 37
                }
                );

            modelBuilder.Entity<Window>().HasData(
                new Window
                {
                    Id = 1,
                    Height = 180,
                    Width = 200
                },
                new Window
                {
                    Id = 2,
                    Height = 190,
                    Width = 210
                }
                );


        }
    }
}
