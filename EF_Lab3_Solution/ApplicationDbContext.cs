using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab3_Solution
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<TeacherTranfere> TeacherTranferes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=LAPTOP-CMR1M1SF\SQLDEV;Database=EF_DbTest;Trusted_Connection=True;Encrypt=false");
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //========================== Fluent API ==================================
            modelBuilder.Entity<TeacherTranfere>()
                .HasOne(s => s.FromSchool)
                .WithMany(t => t.TeacherTranfereForm)
                .HasForeignKey(s => s.FromSchoolID)
            .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<TeacherTranfere>()
               .HasOne(s => s.ToSchool)
               .WithMany(t => t.TeacherTranfereTo)
               .HasForeignKey(s => s.ToSchoolID)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Teacher>().HasKey(t => t.TeacherID);
            modelBuilder.Entity<Teacher>().Property(t=>t.Name).IsRequired();

            modelBuilder.Entity<Teacher>()
                .HasAlternateKey(t => new { t.NationalID, t.phone, t.Code });

            modelBuilder.Entity<Department>()
                .HasIndex(s => s.DepartmentID).IsUnique().IsClustered(false);

            modelBuilder.Entity<School>().HasKey(s => s.SchoolID);


            //========================== Seeding ====================================
            
            
            modelBuilder.Entity<Teacher>().HasData(new Teacher
            {
                TeacherID = 2,
                BirthOfDate = new DateTime(2000,1,29),
                Address = "Assuit",
                Name = "Maged",
                Code = "MMM",
                HiringDate = new DateTime(2022,7,18),
                Jop = "Teacher",
                NationalID = "340005687997",
                phone = "0123456789",
                Qualification = "IT",
                QualificationDate = new DateTime(2020,6,23),
                Note = "ok",
                SchoolID = 1
            });


            modelBuilder.Entity<Department>().HasData(new Department
            {
                DepartmentID = 1,
                Name = "Dep"
            });

            modelBuilder.Entity<School>().HasData(new School
            {
                SchoolID = 1,
                Name = "School1",
                Type = "National",
                DepartmentID = 1

            });

            modelBuilder.Entity<School>().HasData(new School
            {
                SchoolID = 2,
                Name = "School1",
                Type = "InterNational",
                DepartmentID = 1

            });

            modelBuilder.Entity<TeacherTranfere>().HasData(new TeacherTranfere
            {
                TeacherTranfereID = 1,
                Date = new DateTime(2025, 2, 5),
                TeacherID = 1,
                FromSchoolID = 1,
                ToSchoolID = 2,

            });

        }


    }
}
