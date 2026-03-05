using lesson18_WepApI.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace lesson18_WepApI.Data
{
    public class StudentdbContext:DbContext
    {
        public StudentdbContext(DbContextOptions<StudentdbContext> options) : base(options)
        {
        }

        public DbSet<Students> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>().ToTable("Students");
        }
    }
}
