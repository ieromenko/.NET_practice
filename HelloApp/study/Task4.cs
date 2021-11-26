using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.study
{
    internal class Task4
    {
        public static void Do()
    {
            Console.WriteLine("Введите сумму вклада: ");
            double su = Convert.ToDouble(Console.ReadLine());
        double pr;
            if (su< 100)
            {
                pr = 0.05;
            }
            else if (su <= 200)
            {
                pr = 0.07;
            }
            else
{
    pr = 0.1;
}
su += su * pr;

Console.WriteLine($"Сумму вклада после начисления процентов: {su}");
        }
    }
}