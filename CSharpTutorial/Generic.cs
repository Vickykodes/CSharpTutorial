using CSharpTutorial;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class Generic
    {
        public static void Lists()
        {
            List<int> list = new List<int>()
            {
                50,
                100,
                1000000
            };

            //using the Add() method
            list.Add(50000);
            list.Add(90);

            Console.WriteLine("Printing List using Foreach Loop");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================== ");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "One");
            dictionary.Add(2, "Two");
            dictionary.Add(3, "Three");
            dictionary.Add(4, "Four");
            dictionary.Add(5, "Five");
            Console.WriteLine("Dictionary Elements: ");
            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            //
            foreach (var kvp in dictionary)
            {
                Console.WriteLine(kvp);
            }
        }

       
    }
    //method overloading
    public class ClsCalculator
    {
        public static bool AreEqual(int value1, int value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(string value1, string value2)
        {
            return value1 == value2;
        }
        public static bool AreEqual(double value1, double value2)
        {
            return value1 == value2;
        }
    }

    //generic 
    public class CCalculator
    {
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        public static T Book<T>(T value1, T value2)
        {
            return value1;
        }

        public static void Name<T1,T2,T3>(T1 value1, T2 value2)
        {
            return;
        }

    }


}

public class CCalculator<T>
{
    public static void AreEqual(T value1, T value2)
    {

        List<ClsCalculator> list = new List<ClsCalculator>()
        {

        };
        
    }


}

