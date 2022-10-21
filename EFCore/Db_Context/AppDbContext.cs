using EFCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = EFCore.Domain.Task;

namespace EFCore.Db_Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EFCoreDatabase")
                .LogTo(log => Console.WriteLine(log),
                // falter log
                new[] { DbLoggerCategory.Database.Command.Name },
                LogLevel.Information
                )
                // show password in logger
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Task>()
                .HasMany(c => c.Categories)
                .WithMany(t => t.Tasks)
                .UsingEntity<CategoryTask>()
                .Property(ct => ct.CreatedAt)
                .HasDefaultValue("getDate()");
        }
    }

}
