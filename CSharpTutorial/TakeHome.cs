using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    internal class TakeHome
    {
        public static void Main()
        {
            //Adding elements to ArrayList using Add() method
            ArrayList arrayList1 = new ArrayList();
            arrayList1.Add(101); //Adding Integer Value
            arrayList1.Add("James"); //Adding String Value
            arrayList1.Add(true); //Adding Boolean
            arrayList1.Add(4.5); //Adding double
            
            Console.WriteLine("Mama AJ Needs: ");
            foreach (var item in arrayList1)
            {
                Console.WriteLine($"{item} ");
            }

            ArrayList arrayList = new ArrayList()
            {
                    1000,
                    "Ashabi",
                    false,
                    30.25
            };

            //Insert "First Element" at First Position i.e. Index 0
            arrayList.Insert(0, "First Element");
            //Insert "Third Element" at Third Position i.e. Index 2
            arrayList.Insert(2, "Third Element");
            //Iterating through foreach loop
            foreach (var item in arrayList)
            {
                Console.WriteLine($"{item}");
            }

        }
    }
}
