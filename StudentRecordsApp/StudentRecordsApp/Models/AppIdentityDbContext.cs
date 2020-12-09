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
    }
}
