namespace EF_Lab3_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            var context = new ApplicationDbContext();
            
            var selectAllTeachers = context.Teachers.ToList();

            foreach (var item in selectAllTeachers)
            {
                Console.WriteLine(item.Name);
            }

        }
    }
}
