// See https://aka.ms/new-console-template for more information
int i = 1;
int variable = 100;
for (; i < 33 && variable > 100; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"variable = {variable}");
    variable--;
}

for (; variable < 1500; variable = variable + 10)
{
    if (variable == 1000)
        continue;

    Console.WriteLine($"Значение variable в цикле: {variable}");
}   
