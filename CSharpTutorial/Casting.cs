using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    //conversion of datatypes
    public class Casting
    {
        public void Conditions()
        {
            int a = 2;
            int b = 3;
            int c = -13;


            //implicit casting (its automatic conversion)

            double money = 7;

            //explicit casting

            int d = Convert.ToInt16(money);
            bool apple = true;
            string fruitName =Convert.ToString(apple);

            string bookName = "A";
            char Act =Convert.ToChar(bookName);

            //User Input

            Console.WriteLine("Enter your full name");
            Console.WriteLine("--------------------");
            string? fullName = Console.ReadLine();
            Console.WriteLine("--------------------");
            Console.WriteLine("Enter your current age");
            Console.WriteLine("--------------------");
            int? age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("--------------------");
            Console.WriteLine("Output:");
            if (age == null)
            {
                Console.WriteLine("Age cannot be null");
            }
            if (fullName == null)
            {
                Console.WriteLine("Full name cannot be null");
            }
            else
            {
                Console.WriteLine("Your full name is" + " " + fullName + " " + "and your age is" + " " + age); //concatenation
                Console.WriteLine($"Your full name is {fullName} and your age is {age}"); //interpolation
            }


            
        }
                
        public void LudoGame()
        {
            Console.WriteLine("Enter a dice number");
            Console.WriteLine("==================");
            int? dice = int.Parse(Console.ReadLine());

            switch (dice)
            { 
                case 1:
                    Console.WriteLine("Your dice returned one");
                    break;
                case 2:
                    Console.WriteLine("Your dice returned two");
                    break;
                case 3:
                    Console.WriteLine("Your dice returned three");
                     break;
                case 4:
                    Console.WriteLine("Your dice returned four");
                    break;
                case 5:
                    Console.WriteLine("Your dice returned five");
                    break;
                case 6:
                    Console.WriteLine("Your dice returned six");
                    break;
                default:
                    Console.WriteLine("No result");
                    break;
            }
        }
    }

    
}

namespace System.Collections
{
    public static class Business
    {
        public static void Strategy()
        {
            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add("Stephen"); //Adding Duplicate Value
            //arrayList1.Add(001); //Adding Integer
            //arrayList1.Add(true); //Adding Boolean
            //arrayList1.Add(4.5); //Adding double

            //foreach (object item in arrayList1)
            //{
            //    Console.WriteLine(item);
            //}
            //var arrayList2 = new ArrayList()
            //{
            //    100, "Enoch", "Sarah", true, 24.60
            //};
            //foreach (var item in arrayList2)
            //{
            //    Console.WriteLine(item);
            //}
            Console.WriteLine("============================");


            Hashtable hashtable = new Hashtable();
            //Adding elements to the Hash table using key value pair
            hashtable.Add("Reg Number", 10); //key is Eid , value is 1001 
            hashtable.Add("Name", "Jude"); //key is Name , value is James
            hashtable.Add("Salary", 5000); //key is Salary , value is 3500
            hashtable.Add("Location", "Abuja"); //key is Location , value is Mumbai
            hashtable.Add("EmailID", "vicky@g.com"); //key is EmailID , value is a@a.com

            //Console.WriteLine("Print Hashtable ");
            //foreach (var obj in hashtable.Keys)
            //{
            //  Console.WriteLine(obj + " : " + hashtable[obj]);
            //}
            //Checking the key using the Contains method
            Console.WriteLine("Is Reg Number Key Exists : " + hashtable.Contains("EmailID"));
            Console.WriteLine("Is Name Key Exists : " + hashtable.Contains("Name"));
            Console.WriteLine("Is Salary Key Exists : " + hashtable.Contains("Salary"));
            Console.WriteLine("Is Location Key Exists : " + hashtable.Contains("Location"));
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.Contains("EmailID"));

            Console.WriteLine("============================");

            //Checking the key using the ContainsKey method
            Console.WriteLine("Is Reg Number Key Exists : " + hashtable.ContainsKey("Reg Number"));
            Console.WriteLine("Is Name Key Exists : " + hashtable.ContainsKey("Name"));
            Console.WriteLine("Is Salary Key Exists : " + hashtable.ContainsKey("Salary"));
            Console.WriteLine("Is Location Key Exists : " + hashtable.ContainsKey("Location"));
            Console.WriteLine("Is EmailID Key Exists : " + hashtable.ContainsKey("EmailID"));

            Console.WriteLine("============================");

            // Creating a stack collection
            Stack stack = new Stack();
            //Adding item to the stack using the push method
            stack.Push(100);  //integer
            stack.Push("Hi Shazy");  //string
            stack.Push(4.19f);  //float
            stack.Push(true);  //boolean
            stack.Push(60.08);  //double
            stack.Push('A');  //char
            //Printing the stack items using foreach loop
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("============================");


            Queue queue = new Queue();
            //Adding item to the queue using the Enqueue method
            queue.Enqueue(10);
            queue.Enqueue("Hello");
            queue.Enqueue(3.4f);
            queue.Enqueue(true);
            queue.Enqueue(10.5);
            queue.Enqueue('Z');
            //Printing the queue items using foreach loop

            foreach (var item in queue)
            {
                Console.WriteLine(item);

            }

            Console.WriteLine("============================");

            ArrayList Numbers = new ArrayList(3);
            Numbers.Add(100);
            Numbers.Add(200);
            Numbers.Add(300);
            Numbers.Add(400);
            foreach (int Number in Numbers)
            {
                Console.Write(Number + "  ");
            }
        }
    }
}


               