using System;
using Microsoft.EntityFrameworkCore;

namespace lab3_solution
{
    public class AppDbContext : DbContext
    {
        // Task 1: This code creates the DbContext. It tells EF Core what type of database we will be using
        // It also allows you to configure the database settings.
        // Here we are using a SQLite database named database.db
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }

        // Task 2: This DbSet line ensures the DbContext knows about our entity class
        // You need one for each entity class you want in your database
        public DbSet<MadScientist> madScientists {get; set;} = null!;
    }
} 