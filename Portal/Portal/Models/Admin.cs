using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Portal.Models
{

    public class Admin
    {
        //public class Admin

        /*public Admin() 
           {
             Grade = new HashSet<Grades>();
           }*/

        
        public int ID { get; set; }
        [DisplayName("Student ID")]
        public string StudentID { get; set; }

        [DisplayName("Last Name")]
        public string Last_Name { get; set; }
        [DisplayName("First Name")]
        public string First_Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        //public ICollection<Grades> Grade         { get; set; }
        //--
        public int Pq1 { get; set; }
        public int Pq2 { get; set; }
        public int Pq3 { get; set; }
        public int Pa1 { get; set; }
        public int Pa2 { get; set; }
        public int Pa3 { get; set; }
        public float PqAve { get; set; } //prelim quiz ave
        public float PaAve { get; set; } //prelim ass ave
        public float Prelim { get; set; } //prelim tot ave
        public int Mq1 { get; set; }
        public int Mq2 { get; set; }
        public int Mq3 { get; set; }
        public int Ma1 { get; set; }
        public int Ma2 { get; set; }
        public int Ma3 { get; set; }
        public float MqAve { get; set; } //Midterm quiz ave
        public float MaAve { get; set; } //MIdterm ass ave
        public float Midterm { get; set; } //Midterm tot ave
        public int Pfq1 { get; set; }
        public int Pfq2 { get; set; }
        public int Pfq3 { get; set; }
        public int Pfa1 { get; set; }
        public int Pfa2 { get; set; }
        public int Pfa3 { get; set; }
        public float PfqAve { get; set; } //prefi quiz ave
        public float PfaAve { get; set; } //prefi ass ave
        public float Prefinals { get; set; }  //prefi tot ave
        public int Fq1 { get; set; }
        public int Fq2 { get; set; }
        public int Fq3 { get; set; }
        public int Fa1 { get; set; }
        public int Fa2 { get; set; }
        public int Fa3 { get; set; }
        public float FqAve { get; set; } //final quiz ave
        public float FaAve { get; set; } //final ass ave
        public float Finals { get; set; } //final tot ave
    }
    
}
