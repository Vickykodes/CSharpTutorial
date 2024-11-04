using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class Assignment
    {
        public static void Places()
        {
            // FOR Loop
            int school = 5;
            int v = 1;
            for (; v <= school; v++)
            {
                Console.WriteLine("Hello ");
            }
            Console.ReadKey();


            //Nested FOR Loop
            for (; v != 5; v++) //Outer For Loop
            {
                Console.WriteLine($"Outer For Loop : {v}");
                for (int w = 1; w <= 3; w++) //Inner For Loop
                {
                    Console.Write($" {w}");
                }
                Console.WriteLine();
            }

        }

        public static void Drinks()
        {
            //WHILE Loop
            //double softDrinks = 3;
            //Console.WriteLine("number of soft drinks ");
            //double hardDrinks = Convert.ToDouble(Console.ReadLine());
            //while (softDrinks < hardDrinks)
            //{
            //    Console.WriteLine(softDrinks + "  ");
            //    softDrinks++;
            //}

            //// DO WHILE Loop
            int clocks = 5;
            int number = 1;
            do
            {
                Console.Write($"{number} ");
                number++;
            } while (number <= 5);


            do
            {
                Console.WriteLine("I am from outer do-while loop");
                do
                {
                    Console.WriteLine("I am from inner do-while loop ");
                }
                while (1 > 7);
            }
            while (2 > 7);

            Console.ReadKey();
        }
        public static void Literals()
        {
            //Decimal Literal
            //Allowed Digits: 0 to 9 
            int a = 123; //No suffix is required

            // Hexa-Decimal Literal
            //Allowed Digits: 0 to 9 and Character a to f
            int b = 0x523f; //Prefix with 0x, and suffix with f

            //Binary literal
            //Allowed Digits: 0 to 1
            int c = 0b11; // //Prefix with 0b

            Console.WriteLine($"Decimal Literal: {a}");
            Console.WriteLine($"Hexa-Decimal Literal : {b}");
            Console.WriteLine($"Binary Literal: {c}");


            int d = 1; //Integer
            uint e = 10U; //Unsigned Integer
            long f = 100L; //Long
            ulong g = 1000UL; //Unsigned Long

            Console.WriteLine($"Integer Literal: {d}");
            Console.WriteLine($"Unsigned Integer Literal: {e}");
            Console.WriteLine($"Long Literal: {f}");
            Console.WriteLine($"Unsigned Long Literal: {g}");

            // FLOAT-POINT Literal

            double x = 2.45D; //with suffix D
            float y = 10.25F; //with suffix F
            decimal z = 34.05M; //with suffix M

            Console.WriteLine($"Double Literal : {x}");
            Console.WriteLine($"Float Literal : {y}");
            Console.WriteLine($"Decimal Literal : {z}");

            //BOOLEAN Literal
            bool a1 = true;
            bool b2 = false;           
            
            Console.WriteLine(a1);
            Console.WriteLine(b2);

            //Binary Literal
            int b3 = 0b101101;
            int c4 = 0b01011; 

            Console.WriteLine($"Value of B3 is: {b3}");
            Console.WriteLine($"Value of C4 is: {c4}");
            Console.WriteLine($"Char value of B3 is: {Convert.ToChar(b3)}");
            Console.WriteLine($"Char value of C4 is: {Convert.ToChar(c4)}");

            //CHARACTER Literal:
            //Character literal using single quote
            char c5 = 'A';
            Console.WriteLine("Single Quote: " + c5);
            //Character literal using Unicode representation
            char c6 = '\u0041';
            Console.WriteLine("Unicode: " + c6);
            //Character literal using Escape character
            Console.WriteLine("Escape: Hello\tVictoria");

          

        }
    }
}


    

