using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            
            s.FullName = "bob";
            s.FullName = s.FullName.ToUpper();

            Course CPW212 = new Course()
            {
                CourseId = 1,
                CourseTitle = "Advanced .NET",
                Credits = 5,
                Description = "C#"
            };

            s.Schedule.Add(CPW212);

            List<Course> courses = s.Schedule;
            courses.Add(CPW212);
            courses.Add(CPW212);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
