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
            List<int> numbers = new List<int>();//создали пустой список  под цыфры
            List<string> symbols = new List<string>();// создали пустой список  под буквы
            List<string> digits = new List<string>() { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };// создали список цыфр
            foreach (string s in name)
            {
                if (digits.Contains(s))
                {
                    numbers.Add(Convert.ToInt32(s));//конвертировали в инт прям при добавлении в список
                }

                else
                { symbols.Add(s); }// добавление в list symbols

            }
            //           Console.WriteLine($"Символ:{symbols} Кол-во вхождений:{numbers}");
            ////       int max = numbers [0]
            ////       //for (int i = 0 , i < numbers.Count;i++ )
            ///        if (numbers[i] > max )
            ///        {max = numbers[i]}
            ////       //или
            ////       //    {int max = numbers.Max();

            ////       //Console.WriteLine("The largest number is ", Max)}

            ////}







        }
    }
}



