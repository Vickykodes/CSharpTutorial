using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class TwoDArrays
    {
        public bool book;
        public TwoDArrays()
        {
            Console.WriteLine("AJOKE");

        }

        public void Food()
        {

        }

        public void Food(string name)
        {
            
        }
    }


    public static class CollectionTutorial
    {
        //hashtables
        public static void HashTable()
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("Name", "Victoria");
            hashtable.Add("Job", "Secretary");
            hashtable.Add("Salary", 50000);
            hashtable.Add("Location", "Lagos");
            hashtable.Add("Email ID", "ade@a.com");

            Console.WriteLine("Printing Hashtable using Foreach Loop");
            foreach (object obj in hashtable.Keys)
            {
                Console.WriteLine(obj + " : " + hashtable[obj]);
            }


            foreach (DictionaryEntry employee in hashtable)
            {
                Console.WriteLine($"Key: {employee.Key}, Value: {employee.Value}");
            }

            var job = hashtable.Contains("Job");
            Console.WriteLine(job);
            var update = hashtable["Name"] = "Shazy";
            Console.WriteLine(update);

            //using object
            object age = 30;
            age = 30.20;
        }

        public static void Queuing()
        {
            Queue queue = new Queue();

            //queue.Enqueue("Victoria");
            queue.Enqueue(50000);
            queue.Enqueue("ade@a.com");
            queue.Enqueue(true);

            Console.WriteLine("Printing Queue using Foreach Loop");
            foreach (var obj in queue)
            {
                Console.WriteLine(obj);
            }
            var job = queue.Contains("Victoria");
            Console.WriteLine(job);
        }

        public static void Stacking()
        {
            //Stack stack = new Stack();

            //stack.Push(50000);
            //stack.Push("ade@a.com");
            //stack.Push(4.9M);

            //Console.WriteLine("Printing Stack using Foreach Loop");
            //foreach (var obj in stack)
            //{
            //    Console.WriteLine(obj);
            //}

            //Console.WriteLine("==========================");

            //var name = stack.Contains("Victoria");
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(name);


        }
    }
}
