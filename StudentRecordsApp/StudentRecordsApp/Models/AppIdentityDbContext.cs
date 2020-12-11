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
                        StudentId = "100001",
                        FirstName = "Carson",
                        LastName = "Alexander",
                        Email = "carson_alexander@email.com",
                        Address = "Cavite"
                    }, new Student
                    {
                        Id = 2,
                        LastName = "Alonso",
                        FirstName = "Meredith",
                        StudentId = "100002",
                        Email = "meredith_alonso@email.com",
                        Address = "Cavite"
                    }, new Student
                    {
                        Id = 3,
                        LastName = "Anand",
                        FirstName = "Arturo",
                        StudentId = "100003",
                        Email = "arturo_anand@email.com",
                        Address = "Cavite"
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
