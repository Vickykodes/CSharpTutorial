using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public class GenericDelegate
    {
        public static void Market()
        {

            //using func generic to declare delegate
            Console.WriteLine("Func: =============");

            Func<int, int, double> Number1Delegate = new Func<int, int, double>(AddNumber1);
          
            //this method or
            //vegDelegate(1, 2);
            //vegDelegate.Invoke(2, 3);
            //this
            double result1 = Number1Delegate(1, 2);
            Console.WriteLine(result1);

            Console.WriteLine("Action:=============");
            Action<int, double> Number2Delegate = new Action<int, double>(AddNumber2);
             Number2Delegate(2,0.6);

            Console.WriteLine("Predicate:=============");
            Predicate<string> CheckNumberDelegate = new Predicate<string>(CheckNumber);
            bool result2 = CheckNumberDelegate.Invoke("English");
            Console.WriteLine(result2);

        }

        public static double AddNumber1(int a1, int a2)
        {
            return a1 + a2;
        }
        public static void AddNumber2(int no1, double no3)
        {
            Console.WriteLine(no1 + no3);
            return;
        }
        public static bool CheckNumber(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }

        public delegate void LamdaDelegate(string name);
        public delegate void AnonymousDelegate1(string name);
        public delegate int AnonymousDelegate2(int age);

        //using anonymous method
        public static void AnonymousMethod()
        {
            AnonymousDelegate1 anonymousDelegate = delegate (string name)
            {
              Console.WriteLine($"{name}");
            };
            anonymousDelegate.Invoke("Victorrrrrrr");

            AnonymousDelegate2 anonymousDelegate2 = delegate (int age)
            {
                Console.WriteLine($"{age}");
                return age;
            };
            anonymousDelegate2.Invoke(5);

        }

        //Generic delegate with lamda expression =>

        public void LamdaExp()
        {
            //way 1 
            Func<int, int, double> Number1Delegate = (x, y) =>
            {
                return x + y;
            };
            Number1Delegate(4, 9);

            //way 2
            LamdaDelegate lamdaDelegate = (name) =>
            {
                Console.WriteLine($"{name}");
            };
            lamdaDelegate.Invoke("Sheyi");
        }
    }
}
