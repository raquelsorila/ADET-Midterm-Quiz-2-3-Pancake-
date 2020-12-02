using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Portal.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new PortalContext(serviceProvider.GetRequiredService<DbContextOptions<PortalContext>>()))
            {
                if (context.Admin.Any())
                {
                    //if contains any data --- then we return --- we do not seed
                    return;
                }
                context.Admin.AddRange(
                new Admin
                {
                    StudentID = "1030-18",
                    Last_Name = "Sorila",
                    First_Name = "Raquel",
                    Birthdate = DateTime.Parse("1999-04-30"),
                    Age = 21,
                    Address = "GMA, Cavite",
                }

            );
                context.SaveChanges();

            }
        }
    }
}
