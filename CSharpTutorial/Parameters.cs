using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Parameters
    {
        public int MatheMatics(int m,int n)
        {
            return m * n;
        }

        public int Multiplication()
        {
            int a = 2;
            int b = 5;
            var maths = MatheMatics(a,b);
            Console.WriteLine(maths);
            return maths;
        }


        public double Subtraction(double costPrice,double sales)
        {
            double cost= sales - costPrice;
            Console.WriteLine(cost);
            return cost;
        }
    }
    public class Arrays
    {
        public void Fruits()
        {
            int ripeNuts = 10;
            int unripeNuts = 5;

            int[] nuts = new int[2] { ripeNuts, unripeNuts };

            int[] apples = new int[24];
            apples[0] = 2;
            apples[1] = 3;
            apples[2] = 5; 
            apples[3] = 7;
            apples[4] = 8;
            Console.WriteLine(apples[3] = apples[3]);


            string[] buildings = new string[2] { "hut", "duplex" };
            double[] human = new double[2];

            Console.WriteLine(buildings[1]);
            Console.WriteLine(human[0]);
            
            for (int m = 0; m < apples.Length - 1; m++)
            {
                Console.WriteLine($"Numbers[{m}] = {apples[m]}");
            }

            double[] mangoes = new double[3];

            Array.Copy(nuts, mangoes, 1);
            Array.Sort(nuts);

            foreach (int seed in nuts)
            {
                Console.WriteLine($"{seed}");
            }
            foreach(int seed in mangoes)
            {
                Console.WriteLine($"{seed}");
            }
        }
    }
}
