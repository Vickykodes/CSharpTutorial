using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public static class Iterations
    {
        public static void Loops()
        {
            //while loop

            int inputs= 5;
            Console.Write("Cast your vote: ");
            int votes = Convert.ToInt16(Console.ReadLine());
            while (inputs <= votes)
            {
                int x = 1;
                while (x > inputs)
                {
                    Console.Write(x + " ");
                    x++;
                }
                Console.WriteLine(votes + " votes casted");
                inputs++;
            }
        }
    }
}
