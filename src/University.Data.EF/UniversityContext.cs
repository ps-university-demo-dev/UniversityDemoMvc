using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using University.Core.Domain;
using University.Data.DemoData;
using University.Data.EF.Config;

namespace University.Data.EF
{
    public class UniversityContext : DbContext
    {

        public UniversityContext(DbContextOptions options) : base(options)
        {
            
        }


        //public DbSet<AcademicYear> AcademicYears { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<Department> Departments { get; set; }


        public DbSet<Grade> Grades { get; set; }


        public DbSet<Semester> Semesters { get; set; }


        //public DbSet<Student> Students { get; set; }

        //public DbSet<StudentStatus> StudentStatuses { get; set; }

        public DbSet<Term> Terms { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Apply Configurations
            modelBuilder.ApplyConfiguration(new SemesterConfiguration());
            modelBuilder.ApplyConfiguration(new TermConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());


            


            // Seed Data
            this.SeedData(modelBuilder);
        }


        private void SeedData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Semester>().HasData(
                UniversityData.Semesters.AllSemesters
            );


            modelBuilder.Entity<Term>().HasData(
                UniversityData.Terms.AllTerms
                .Select(t => new Term() { TermCode = t.TermCode, Year = t.Year, SemesterCode = t.SemesterCode })
                .ToList()
            );

            modelBuilder.Entity<Grade>().HasData(
                UniversityData.Grades.AllGrades
            );

            modelBuilder.Entity<Department>().HasData(
                UniversityData.Departments.AllDepartments
            );

            modelBuilder.Entity<Course>().HasData(
                UniversityData.Courses.AllCourses
                .Select(c => new Course() { CourseId = c.CourseId, CourseName = c.CourseName, CourseNumber = c.CourseNumber, Credits = c.Credits, DepartmentCode = c.DepartmentCode })
                .ToList()
            );

        }






    }
}
