using lesson19_WebApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace lesson19_WebApi.Data
{
    public class StudentsDbContext : DbContext
    {
        public StudentsDbContext(DbContextOptions<StudentsDbContext> options) : base(options)

        {

        }

        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Genders> Genders { get; set; }
        public DbSet<StudentCourses> StudentCourses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Students>().ToTable("Students");
            modelBuilder.Entity<Courses>().ToTable("Courses");
            modelBuilder.Entity<Genders>().ToTable("Genders");
            modelBuilder.Entity<StudentCourses>().ToTable("StudentCourses");

            modelBuilder.Entity<StudentCourses>().HasKey(x => new { x.StudentId, x.CourseId });
        }
    }
}
