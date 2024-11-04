using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharpTutorial.DelegateTutorial;

namespace CSharpTutorial
{
    public class DelegateTutorial
    {
        //declare delegate
        public delegate void CountryDelegate(string name);

        //handler method
        public void Country(string name)
        {
            Console.WriteLine($"{name}");
        }

        public void Continent(CountryDelegate name)
        {
            Console.Write($"Continent name:");
            name("Nigeria");
        }
    }

    public delegate void RectangleDelegate(double Width, double Height);
    public class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine($"Area is {Width * Height}");
        }
        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
        }

        public static void MainMethod()
        {
            //single cast method
            var delegateTutorial = new DelegateTutorial();
            var countryDelegate = new CountryDelegate(delegateTutorial.Country);
            //countryDelegate.Invoke("Nigeria");
            delegateTutorial.Continent(countryDelegate);


            //multicast method
            Rectangle rect = new Rectangle();
            RectangleDelegate rectDelegate = new RectangleDelegate(rect.GetArea);
            //  RectangleDelegate rectDelegate = rect.GetArea;

            //Adding a method from delegate object
            rectDelegate += rect.GetPerimeter;
            rectDelegate(10, 15.00);

            //Removing a method from delegate object
            rectDelegate -= rect.GetPerimeter;
            rectDelegate(20.00, 5.00);

            //Delegate[] InvocationList = rectDelegate.GetInvocationList();
            //Console.WriteLine("InvocationList:");
            //foreach (var item in InvocationList)
            //{
            //    Console.WriteLine($"{item}");
            //}
            //Invoking Multicast Delegate

            Console.ReadKey();
        }

    }


    
}
