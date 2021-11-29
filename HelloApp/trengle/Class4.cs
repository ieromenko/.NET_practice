using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.trengle
{
    internal class Class1
    {
        public void SD()
        {

            string s1 = "Hello я Катя, как дела";
            string s2 = string.Empty;

            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != ' ')
                {
                    s2 += s1[i];

                    Console.WriteLine($"Without space:{s2}");
                }
            }
        }
    }
}