using Microsoft.EntityFrameworkCore;
using PancakeApp.Models;
using System;

namespace PancakeApp.Data
{
    public class StudentRecordContext : DbContext 
    {
        public StudentRecordContext(DbContextOptions<StudentRecordContext> options) : base(options)
        {
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Grade> Grade{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User");
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        Id = 1,
                        UserId = "100001",
                        FirstName = "Carson",
                        LastName = "Alexander",
                        Email = "carson_alexander@email.com",
                        Address = "Cavite",
                        Password = "1234",
                        Role = "2"
                    }, new User
                    {
                        Id = 2,
                        LastName = "Alonso",
                        FirstName = "Meredith",
                        UserId = "100002",
                        Email = "meredith_alonso@email.com",
                        Address = "Cavite",
                        Password = "1234",
                        Role = "2"
                    }, new User
                    {
                        Id = 3,
                        LastName = "Anand",
                        FirstName = "Arturo",
                        UserId = "100003",
                        Email = "arturo_anand@email.com",
                        Address = "Cavite",
                        Password = "1234",
                        Role = "2"
                    }
                );

            modelBuilder.Entity<Grade>()
                .ToTable("Grade");
            modelBuilder.Entity<Grade>()
                .HasData(
                    new Grade
                    {
                        Id = 1,
                        UserID = 1,
                        Prelim_Assign1 = 6,
                        Prelim_Assign2 = 7,
                        Prelim_Assign3 = 6,
                        Prelim_Quiz1 = 8,
                        Prelim_Quiz2 = 7,
                        Prelim_Quiz3 = 9,
                        Midterm_Assign1 = 6,
                        Midterm_Assign2 = 5,
                        Midterm_Assign3 = 9,
                        Midterm_Quiz1 = 8,
                        Midterm_Quiz2 = 7,
                        Midterm_Quiz3 = 9,
                        Prefinal_Assign1 = 6,
                        Prefinal_Assign2 = 7,
                        Prefinal_Assign3 = 7,
                        Prefinal_Quiz1 = 5,
                        Prefinal_Quiz2 = 7,
                        Prefinal_Quiz3 = 9,
                        Final_Assign1 = 6,
                        Final_Assign2 = 8,
                        Final_Assign3 = 8,
                        Final_Quiz1 = 7,
                        Final_Quiz2 = 7,
                        Final_Quiz3 = 7
                    },
                    new Grade
                    {
                        Id = 2,
                        UserID = 2,
                        Prelim_Assign1 = 6,
                        Prelim_Assign2 = 7,
                        Prelim_Assign3 = 5,
                        Prelim_Quiz1 = 7,
                        Prelim_Quiz2 = 7,
                        Prelim_Quiz3 = 9,
                        Midterm_Assign1 = 6,
                        Midterm_Assign2 = 8,
                        Midterm_Assign3 = 8,
                        Midterm_Quiz1 = 8,
                        Midterm_Quiz2 = 5,
                        Midterm_Quiz3 = 9,
                        Prefinal_Assign1 = 6,
                        Prefinal_Assign2 = 7,
                        Prefinal_Assign3 = 7,
                        Prefinal_Quiz1 = 5,
                        Prefinal_Quiz2 = 7,
                        Prefinal_Quiz3 = 9,
                        Final_Assign1 = 6,
                        Final_Assign2 = 8,
                        Final_Assign3 = 8,
                        Final_Quiz1 = 8,
                        Final_Quiz2 = 7,
                        Final_Quiz3 = 9
                    },
                    new Grade
                    {
                        Id = 3,
                        UserID = 3,
                        Prelim_Assign1 = 6,
                        Prelim_Assign2 = 7,
                        Prelim_Assign3 = 5,
                        Prelim_Quiz1 = 7,
                        Prelim_Quiz2 = 7,
                        Prelim_Quiz3 = 9,
                        Midterm_Assign1 = 6,
                        Midterm_Assign2 = 8,
                        Midterm_Assign3 = 8,
                        Midterm_Quiz1 = 8,
                        Midterm_Quiz2 = 5,
                        Midterm_Quiz3 = 9,
                        Prefinal_Assign1 = 6,
                        Prefinal_Assign2 = 5,
                        Prefinal_Assign3 = 7,
                        Prefinal_Quiz1 = 5,
                        Prefinal_Quiz2 = 7,
                        Prefinal_Quiz3 = 9,
                        Final_Assign1 = 6,
                        Final_Assign2 = 9,
                        Final_Assign3 = 8,
                        Final_Quiz1 = 5,
                        Final_Quiz2 = 7,
                        Final_Quiz3 = 7
                    }
                );
        }
    }
}
