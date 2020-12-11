using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentRecordsApp.Models;
using System;

namespace StudentRecordsApp.Models
{
    public class AppIdentityDbContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options) : base(options) { }

        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            string ADMIN_ID = "02174cf0";
            string ROLE_ID = "341743f0";

            //seed admin role
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "Admin",
                Id = ROLE_ID,
                ConcurrencyStamp = ROLE_ID
            });

            //create user
            var appUser = new AppUser
            {
                Id = ADMIN_ID,
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                FirstName = "Raquel",
                LastName = "Sorila",
                UserName = "admin",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                NormalizedUserName = "ADMIN",
                UserID = "0",
                PasswordHash = "AQAAAAEAACcQAAAAEEXvj4HDNFuXn4B2w0suAsDOGEoaykEtqSVJa7xE3m6Kf2reoj3Q7FFc0JHW6A/rzQ=="
            };

            //seed user
            builder.Entity<AppUser>().HasData(appUser);

            //set user role to admin
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = ROLE_ID,
                UserId = ADMIN_ID
            });

            builder.Entity<Student>()
                .ToTable("Student");
            builder.Entity<Student>()
                .HasData(
                    new Student
                    {
                        Id = 1,
                        StudentId = "1624-18",
                        FirstName = "Ronald",
                        LastName = "Colata",
                        MiddleName = "P.",
                        Email = "ronaldcolata@email.com",
                        Address = "Las Pinas City"
                    }, new Student
                    {
                        Id = 2,
                        LastName = "Guyala",
                        FirstName = "Kyla Joyce",
                        StudentId = "1811-18",
                        Email = "kylaguyala@email.com",
                        Address = "Muntinlupa City"
                    },
                    new Student
                    {
                        Id = 3,
                        LastName = "Rosales",
                        FirstName = "Iris",
                        StudentId = "1238-18",
                        Email = "irisrosalesmail.com",
                        Address = "Sta. Rosa Laguna"
                    }
                );

            builder.Entity<Grade>()
                .ToTable("Grade");
            builder.Entity<Grade>()
                .HasData(
                    new Grade
                    {
                        Id = 1,
                        StudentID = 1,
                        Prelim_Assign1 = 90,
                        Prelim_Assign2 = 85,
                        Prelim_Assign3 = 88,
                        Prelim_Quiz1 = 87,
                        Prelim_Quiz2 = 89,
                        Prelim_Quiz3 = 90,
                        Midterm_Assign1 = 91,
                        Midterm_Assign2 = 92,
                        Midterm_Assign3 = 93,
                        Midterm_Quiz1 = 84,
                        Midterm_Quiz2 = 86,
                        Midterm_Quiz3 = 93,
                        Prefinal_Assign1 = 97,
                        Prefinal_Assign2 = 89,
                        Prefinal_Assign3 = 90,
                        Prefinal_Quiz1 = 97,
                        Prefinal_Quiz2 = 87,
                        Prefinal_Quiz3 = 83,
                        Final_Assign1 = 82,
                        Final_Assign2 = 80,
                        Final_Assign3 = 78,
                        Final_Quiz1 = 90,
                        Final_Quiz2 = 70,
                        Final_Quiz3 = 70
                    },
                    new Grade
                    {
                        Id = 2,
                        StudentID = 2,
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
                        StudentID = 3,
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
