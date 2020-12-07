using PancakeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PancakeApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(StudentRecordContext context)
        {
            if (context.User.Any())
            {
                return;
            }

            var users = new User[]
            {
                new User { LastName = "Alexander", FirstName = "Carson", UserId = "100001", 
                    Email = "carson_alexander@email.com", Address = "Cavite", Password = "1234", Role = "2"},
                new User { LastName = "Alonso", FirstName = "Meredith", UserId = "100002",
                    Email = "meredith_alonso@email.com", Address = "Cavite", Password = "1234", Role = "2"},
                new User { LastName = "Anand", FirstName = "Arturo", UserId = "100003",
                    Email = "arturo_anand@email.com", Address = "Cavite", Password = "1234", Role = "2"},
            };

            context.User.AddRange(users);
            context.SaveChanges();
        }
    }
}
