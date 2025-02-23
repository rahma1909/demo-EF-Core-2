using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using demo.config;
using demo.Models;
using Microsoft.EntityFrameworkCore;

namespace demo.contexts
{
    internal class CompanyDbContext:DbContext
    {
        public CompanyDbContext():base()
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new EmployeeConfig());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #region fluent API one to one
            //modelBuilder.Entity<Employee>().HasOne(e => e.department)
            //                               .WithOne(d => d.Manager)

            //         .HasForeignKey<Department>(d => d.empId);
            #endregion

            #region fluent APi one to many

            modelBuilder.Entity<Department>().HasMany(d => d.employee)
                .WithOne(e => e.workfor)
                .HasForeignKey(e=>e.workforID);

            #endregion

            #region fluent Api many to many

            #region compost primarykey

            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentId, sc.CourseId });
            #endregion
            #endregion


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=company;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
