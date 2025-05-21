using Microsoft.EntityFrameworkCore;

namespace EF_Lab3_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ApplicationDbContext context = new ApplicationDbContext();

            #region Test Connection
            //var selectAllTeachers = context.Teachers.ToList();

            //foreach (var item in selectAllTeachers)
            //{
            //    Console.WriteLine(item.Name);
            //}
            #endregion

            #region Insert
            //var dept2 = new Department
            //{
            //    Name = "Dept2"
            //};

            //context.Departments.Add(dept2);

            //var school = new List<School>()
            //{
            //    new School()
            //    {
            //        Name = "School3",
            //        Type = "Intern",
            //        DepartmentID = 2,
            //    },
            //    new School()
            //    {
            //        Name = "School4",
            //        Type = "Intern",
            //        DepartmentID = 3,
            //    },
            //};
            //context.Schools.AddRange(school);


            //var addTeachers = new List<Teacher>()
            //{
            //    new Teacher()
            //    {
            //        BirthOfDate = new DateTime(1999,1,29),
            //        Address = "Assuit",
            //        Name = "Samuel",
            //        Code = "SSS",
            //        HiringDate = new DateTime(2021,7,18),
            //        Jop = "Teacher",
            //        NationalID = "240005697997",
            //        phone = "0125456789",
            //        Qualification = "IT",
            //        QualificationDate = new DateTime(2020,6,23),
            //        Note = "ok",
            //        SchoolID = 15
            //    },
            //    new Teacher()
            //    {

            //        BirthOfDate = new DateTime(2001,10,5),
            //        Address = "Assuit",
            //        Name = "Abanoub",
            //        Code = "AAA",
            //        HiringDate = new DateTime(2021,7,18),
            //        Jop = "Teacher",
            //        NationalID = "370005697997",
            //        phone = "01111116789",
            //        Qualification = "IT",
            //        QualificationDate = new DateTime(2020,6,23),
            //        Note = "ok",
            //        SchoolID = 16
            //    }

            //};

            //context.Teachers.AddRange(addTeachers);


            //var addTeachersTrans = new List<TeacherTranfere>()
            //{
            //    new TeacherTranfere()
            //    {

            //        Date = new DateTime(2025, 2, 5),
            //        TeacherID = 10,
            //        FromSchoolID = 1,
            //        ToSchoolID = 15,
            //    },

            //    new TeacherTranfere()
            //    {

            //        Date = new DateTime(2025, 2, 5),
            //        TeacherID = 11,
            //        FromSchoolID = 1,
            //        ToSchoolID = 16,
            //    }

            //};

            //context.TeacherTranferes.AddRange(addTeachersTrans);


            #endregion

            #region update
            //var updateDept = context.Departments.FirstOrDefault(d=>d.DepartmentID==3);
            //updateDept.Name = "Dept3";
            //context.Attach(updateDept);
            //context.Entry(updateDept).State = EntityState.Modified;
            //context.Departments.Update(updateDept);
            #endregion

            #region Delete
            //var deleteTe = context.Schools.AsTracking().FirstOrDefault(d => d.SchoolID == 15);
            //context.Entry(deleteTe).State = EntityState.Deleted;
            //context.Schools.Remove(deleteTe);
            #endregion

            context.SaveChanges();
        }
    }
}
