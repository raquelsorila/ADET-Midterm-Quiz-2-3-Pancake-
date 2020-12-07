using System;
using System.ComponentModel.DataAnnotations;

namespace PancakeApp.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public User User { get; set; }
        public Grade Grade { get; set; }
    }
}
