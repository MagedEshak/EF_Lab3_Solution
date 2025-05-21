using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab3_Solution
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public DateTime BirthOfDate { get; set; }
        public string NationalID { get; set; }
        public string Code { get; set; }
        public string Jop { get; set; }
        public string phone { get; set; }
        public string Qualification { get; set; }
        public DateTime QualificationDate { get; set; }
        public DateTime HiringDate { get; set; }
        public string? Address { get; set; }
        public string Note { get; set; }
        
        public int SchoolID { get; set; }

        public virtual School School { get; set; }

        public List<TeacherTranfere> TeacherTranferes { get; set; }
    }
}
