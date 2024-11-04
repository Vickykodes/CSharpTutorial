using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    public static class LinqLambda
    {
        public static void LamdaExp()
        {
            List<int> list = new List<int>() { 6, 7, 8, 9, 10};
            list.Add(1);
            List<int> oddNumbers = list.FindAll(X => (X % 2) == 0);

            foreach (var a in oddNumbers)
            {
                Console.WriteLine( a);                                
            }
        }
    }
}
