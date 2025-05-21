using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Lab3_Solution
{
    public class Department
    {
        public int DepartmentID{ get; set; }
        public string Name { get; set; }

        public List<School> Schools { get; set; }
    }
}
