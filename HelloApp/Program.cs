// See https://aka.ms/new-console-template for more information

int variable = 1;
int i = 1;

Console.WriteLine($"Значение variable до цикла: {variable}");
Console.WriteLine($"Значение i до цикла: {i}");

for ( ; ; variable = variable + 10)
{
    if (variable > 70 && variable < 90)
    {
        continue;
    }

    Console.WriteLine($"Значение variable в цикле: {variable}");
    Console.WriteLine($"Значение i в цикле: {i}");

    if (variable >= 100)
    {
        i = 10;
    }

    if(i >= 10)
    {
        break;
    }
}

Console.WriteLine($"Значение variable по итогу: {variable}");
Console.WriteLine($"Значение i по итогу: {i}");