using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Homework
    {

        public void Assignment()
        {
            int f = 3;
            int g = 5;
            int h = 7;

            //implicit casting (its automatic conversion)

            double goods = 7;

            //explicit casting

            int j = Convert.ToInt16(goods);
            bool seed = true;
            string fruitName = Convert.ToString(seed);

            string lastName = "G";
            char Act = Convert.ToChar(lastName);


        }
        public void ClassGame()
        {
            Console.WriteLine("Enter a pie number");
            Console.WriteLine("==================");
            int? pie = int.Parse(Console.ReadLine());

            switch (pie)
            { 
                case 1:
                    Console.WriteLine("Your pie returned two");
                    break;
                case 2:
                    Console.WriteLine("Your pie returned four");
                    break;
                case 3:
                    Console.WriteLine("Your pie returned six");
                     break;
                case 4:
                    Console.WriteLine("Your pie returned eight");
                    break;
                case 5:
                    Console.WriteLine("Your pie returned ten");
                    break;
                case 6:
                    Console.WriteLine("Your pie returned twelve");
                    break;
                default:
                    Console.WriteLine("Null");
                    break;
            }
}

        public int Math(int c, int d)
        {
            return c * d;
        }

        public int Digital()
        {
            int p = 3;
            int q = 7;
            var maths = Math(p, q);
            Console.WriteLine(maths);
            return maths;
        }
    }
}
