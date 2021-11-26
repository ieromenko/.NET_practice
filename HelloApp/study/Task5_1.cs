namespace HelloApp
{
    public class Task7
    {
        public static void Do()

        {
            Console.WriteLine("Введите числа: ");
            string[] num = Console.ReadLine().Split(',');
                                   
            for (string i = "0"; i < num.Length; i++) 
            {
                for (string a = "0"; a < num.Length; a++)
                
                    if (a == i) //исключают сравнения самих с собой
                    {
                        continue;
                    }

                    if (num[i] == num[a]) //поиск 2 одинаковых значений
                    {
                        
                    }
                }
                Console.WriteLine($"{num[i]},")
            }


        }
    }






