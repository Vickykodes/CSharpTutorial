using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public static class TicketOut
    {
        public static void Numbers()
        {
            bool IsEqual = ClsCalculator.AreEqual(10, 10);
            if (IsEqual)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }

            Console.WriteLine("======================");

            bool Digits = ClsCalculator.AreEqual(05, 5);
            if (Digits)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.WriteLine("===============================");
        }
        public static void Juice()
       {
            ArrayList Numbers = new ArrayList(3);
            Numbers.Add(100);
            Numbers.Add(200);
            Numbers.Add(300);
            //It is also possible to store string values
           // Numbers.Add("Hi"); 
            foreach (int Number in Numbers)
            {
                Console.WriteLine(Number);
            }

            Console.WriteLine("===============================");

            List<int> Combo = new List<int>();
            Combo.Add(10);
            Combo.Add(20);
            Combo.Add(30);
            Combo.Add(40);
            Combo.Add(50);
            //The following line give you compile time error as the value is string
           // Combo.Add("Hello");
            Console.WriteLine("List of Elements: ");
            foreach (int item in Combo)
            {
                Console.WriteLine($"{item} ");
            }

            Console.WriteLine("===============================");

            HashSet<int> Combat = new HashSet<int>();
            Combat.Add(11);
            Combat.Add(22);
            Combat.Add(33);
            Combat.Add(44);
                        
            Console.WriteLine("List of Elements: ");
            foreach (int item in Combat)
            {
                Console.WriteLine($"{item} ");
            }

            Stack<string> States = new Stack<string>();
            States.Push("Lagos");
            States.Push("Osun");
            States.Push("Enugu");
            States.Push("Ogun");
            States.Push("Ondo");
            Console.WriteLine("Stack Elements: ");
            foreach (string country in States)
            {
                Console.WriteLine($"{country} ");
            }

            Console.WriteLine("===============================");

            List<string> countries = new List<string>
            {
                "Pepsi",
                "Smoove",
                "Teem",
                "Coke"
            };
            
            Console.WriteLine("Accessing Generic List Elements using For Each Loop");
            foreach (var item in countries)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============================");

            int[] array = new int[5] { 5, 15, 25 , 35 ,45 };
            // Copy the array to a List.
            List<int> copiedList = new List<int>(array);
            Console.WriteLine("Copied Elements in List");
            foreach (var item in copiedList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============================");

            string[] arrays = new string[] { "INDIA", "USA", "UK" };
            // Copy the array to a List.
            List<string> copied = new List<string>(arrays);
            Console.WriteLine("Copied Elements in List");
            foreach (var item in copied)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============================");

            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
                                                        
            //stack.Push("Hell0"); //Compile-Time Error
            Console.WriteLine("Generic Stack Elements1 : ");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Stack<string> farm = new Stack<string>();
            farm.Push("Trophy");
            farm.Push("Legend");
            farm.Push("Stout");
                        
            Console.WriteLine("Generic Stack Elements2 : ");
            foreach (var item in farm)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============================");

            Queue<int> queue = new Queue<int>();
            //Adding Elements to the Queue 
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);
            
            Console.WriteLine("Generic Queue Elements1 : ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }


            Queue<string> fruits = new Queue<string>();
            //Adding Elements to the Queue 
            fruits.Enqueue("Apple");
            fruits.Enqueue("Mango");
            fruits.Enqueue("Grape");
            fruits.Enqueue("Orange");

            Console.WriteLine("Generic Queue Elements2 : ");
            foreach (var item in fruits)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===============================");

            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "IND", "Mumbai, Delhi, Bhubaneswar" }
            };
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }

        }
    }
}
