using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SchoolContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }

        public SchoolContext()
        {}

        public SchoolContext(DbContextOptions<SchoolContext> options) :base(options)
        {}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;");
            }
            
        }
    }
}
