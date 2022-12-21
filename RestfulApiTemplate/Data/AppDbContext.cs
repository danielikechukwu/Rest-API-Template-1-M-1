using Microsoft.EntityFrameworkCore;
using RestfulApiTemplate.Models;

namespace RestfulApiTemplate.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId});

            modelbuilder.Entity<StudentCourse>().HasOne<Student>(sc => sc.Student).WithMany(sc => sc.studentcourse);

            modelbuilder.Entity<StudentCourse>().HasOne<Course>(sc => sc.Course).WithMany(sc => sc.studentcourse);
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<StudentCourse> studentsCourses { get; set; }
    }
}
