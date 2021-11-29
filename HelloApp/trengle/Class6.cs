using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.trengle
{
    public class Class33
    {
        public void Ola()
        {
            Console.WriteLine("Введите символы: ");
            string[] name = Console.ReadLine().Split();
            List<int> numbers = new List<int>();
            List<string> symbols = new List<string>();
            List<string> digits = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            foreach (string s in name)
            {
                if (digits.Contains(s))
                {
                    numbers.Add(Convert.ToInt32(s));
                }

                else
                { symbols.Add(s); }

            }
            Console.WriteLine($"Символ:{symbols} Кол-во вхождений:{numbers}");
                }







    }
}

