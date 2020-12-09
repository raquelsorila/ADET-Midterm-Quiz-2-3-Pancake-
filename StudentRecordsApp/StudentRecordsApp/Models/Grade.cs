using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRecordsApp.Models
{
    public class Grade
    {
        public int Id { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int Prelim_Quiz1 { get; set; }
        public int Prelim_Quiz2 { get; set; }
        public int Prelim_Quiz3 { get; set; }
        public int Prelim_Assign1 { get; set; }
        public int Prelim_Assign2 { get; set; }
        public int Prelim_Assign3 { get; set; }

        public int Midterm_Quiz1 { get; set; }
        public int Midterm_Quiz2 { get; set; }
        public int Midterm_Quiz3 { get; set; }
        public int Midterm_Assign1 { get; set; }
        public int Midterm_Assign2 { get; set; }
        public int Midterm_Assign3 { get; set; }

        public int Prefinal_Quiz1 { get; set; }
        public int Prefinal_Quiz2 { get; set; }
        public int Prefinal_Quiz3 { get; set; }
        public int Prefinal_Assign1 { get; set; }
        public int Prefinal_Assign2 { get; set; }
        public int Prefinal_Assign3 { get; set; }

        public int Final_Quiz1 { get; set; }
        public int Final_Quiz2 { get; set; }
        public int Final_Quiz3 { get; set; }
        public int Final_Assign1 { get; set; }
        public int Final_Assign2 { get; set; }
        public int Final_Assign3 { get; set; }
    }
}
