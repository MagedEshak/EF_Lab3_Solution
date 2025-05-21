using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab3_Solution
{
    public class TeacherTranfere
    {
        public int TeacherTranfereID { get; set; }
        public DateTime Date { get; set; }

        public int TeacherID { get; set; }

        public int FromSchoolID { get; set; }

        public int ToSchoolID { get; set; }

        public virtual Teacher Teacher { get; set; }
        public virtual School FromSchool { get; set; }
        public virtual School ToSchool { get; set; }


    }
}
