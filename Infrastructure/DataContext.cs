
using Core.entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {


        }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Project>().Property(x => x.Id).HasDefaultValueSql("NEWID()");
            modelBuilder.Entity<Project>().HasData(
                new Project(Guid.NewGuid(),"Portfolio", "The purpose of this project is to create an online presence\n" +
                "that effectively represents my skills, experiences," +
                "and projects to potential employers, clients, and collaborators.\n" +
                "It showcases my capabilities as a web developer\n" +
                "and provides a platform for networking and professional connections.", "fa-regular fa-address-card")
                );
        }
    }
}
