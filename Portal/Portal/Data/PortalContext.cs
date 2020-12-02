using Microsoft.EntityFrameworkCore;
using Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Data
{
    public class PortalContext : DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options) : base(options)
        {
            //do nothing here
        }

        public DbSet<Models.Admin> Admin { get; set; }

        //public DbSet<Student> Student { get; set; }

    }
}
