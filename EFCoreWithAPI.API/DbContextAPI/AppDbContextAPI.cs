using EFCoreWithAPI.API.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCoreWithAPI.API.DbContextAPI
{
    public class AppDbContextAPI : DbContext
    {
        public AppDbContextAPI(DbContextOptions<AppDbContextAPI> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }

        // seed default data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                        .HasData(
                                 new Student() { Id = 1,
                                     FirstName = "Hussein",
                                     LastName = "Issa",
                                     Score = 1000 },
                                  new Student()
                                  {
                                      Id = 2,
                                      FirstName = "Hasan",
                                      LastName = "Issa",
                                      Score = 80
                                  },
                                   new Student()
                                   {
                                       Id = 3,
                                       FirstName = "Ramiz",
                                       LastName = "Issa",
                                       Score = 85
                                   }
           );
        }
    }
}
