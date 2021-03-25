using BookProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookProject
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BookDb;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData(
                    new Book()
                    {
                        Id = 1,
                        Title = "The Great Gatsby",
                        AuthorId = 1
                    },
                    new Book()
                    {
                        Id = 2,
                        Title = "Mistborn",
                        AuthorId = 2
                    }
                );
            modelBuilder.Entity<Author>().HasData(
                    new Author()
                    {
                        Id = 1,
                        FirstName = "F.",
                        MiddleName = "Scott",
                        LastName = "Fitzgerald"
                    },
                    new Author()
                    {
                        Id = 2,
                        FirstName = "Brandon",
                        LastName = "Sanderson"
                    }
                );
        }
    }
}
