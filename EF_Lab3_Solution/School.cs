using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab3_Solution
{
    public class School
    {
        public int SchoolID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        public int DepartmentID { get; set; }

        public virtual Department Department { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<TeacherTranfere> TeacherTranfereForm { get; set; }

        public List<TeacherTranfere> TeacherTranfereTo { get; set; }

    }
}
