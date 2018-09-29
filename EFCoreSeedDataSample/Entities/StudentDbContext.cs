using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EFCoreSeedDataSample.Entities
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var data = new List<Student>()
            {
                new Student{  Id=Guid.NewGuid(), Name="Stu 1" },
                new Student{  Id=Guid.NewGuid(), Name="Stu 2" },
                new Student{  Id=Guid.NewGuid(), Name="Stu 3" },
                new Student{  Id=Guid.NewGuid(), Name="Stu 4" },
            };

            modelBuilder.Entity<Student>().HasData(data.ToArray());
        }
    }
}