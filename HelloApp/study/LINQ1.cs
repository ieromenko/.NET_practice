using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.study
{
    internal class LINQ1

    {
        public static void Main()
        {
            int[] numbers = { 1, -1, 3, -3, 5, -5 };
            var elements = numbers.ToList().Where(i => i>0).Select(e => new {p= e, Sqrt = Sqrt (e)}) ;

            
            foreach (var n in elements)
                Console.WriteLine(n);
            
        }
        
        static int Sqrt(int x)
        {
            return x * x;
           
        }

    }
}
   