using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    internal class Task3
    {
        public static void Do()
        {
            Console.WriteLine("Вклад: ");
            double s = Convert.ToDouble(Console.ReadLine());

            if (s < 100)
            {
                s += s * 0.05;
            }
            

            else if (s <= 200 && s >= 100)
            {
                s += s * 0.07;
               
            }
     

            else
            {
                s += s * 0.1;
            }
            Console.WriteLine($"Сумму  {s}");

        }           
    }
}
    

