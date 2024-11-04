using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpTutorial
{
    public class Work
    {
        //SingleCast Delegate

        public delegate void ClassRoom(int age);

        public void Students(int age)
        {
            Console.WriteLine($"{age}");
        }

        public static void Grades(ClassRoom age)
        {
            Console.Write($"age is: ");
            age(10);
        }

        public static void MainOutput()
        {
            var work = new Work();
            var classRoom = new ClassRoom(work.Students);
            Grades(classRoom);
        }
    }             
    
}
