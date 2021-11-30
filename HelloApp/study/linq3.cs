using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.study
{
    internal class linq3
    {
        public void Ola()
        {
            Console.WriteLine("Введите символы: ");
            string[] name = Console.ReadLine().Split();
            List<string> digits = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };// создали список цыфр
            IEnumerable<int> evens = from i in name
                                        where digits.Contains(i)
                                        select Convert.ToInt32(i);
            foreach (int e in evens)
                Console.WriteLine(e);

            int max1 = evens.Max();
            Console.WriteLine($"Максимальное значение:{max1}");
            

        }
    }
}

