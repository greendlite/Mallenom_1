// Чтение конфигурации из appsettings.json
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();






















//--------------------------------
//-----------Задание #1-----------
//--------------------------------
int a = 5;
int b = 19;

List<int> lst = new();

for (int i = a; i <= b; i += 2)
{
    lst.Add(i);
}

int[] oddNumbers = lst.ToArray();

// Вывод массива
Console.WriteLine("Задание #1");
Console.WriteLine($"Массив: [{string.Join(", ", oddNumbers)}]");



//--------------------------------
//-----------Задание #2-----------
//--------------------------------
double[] randomValues = new double[13];
var rangeMin = -12.0;
var rangeMax = 15.0;
Random rn = new();

for (int i = 0; i < randomValues.Length; i++)
{
    randomValues[i] = Math.Round(rangeMin + (rangeMax - rangeMin) * rn.NextDouble(), 2);
}

// Вывод массива
Console.WriteLine("\nЗадание #2");
Console.WriteLine($"Массив: [{string.Join(", ", randomValues)}]");



//--------------------------------
//-----------Задание #3-----------
//--------------------------------
double[,] k = new double[8, 13];

int rows = k.GetLength(0);
int cols = k.GetLength(1);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        var x = randomValues[j];

        if (oddNumbers[i] == 9)
        {
            //var res1 = x + 0.5;
            //var res2 = x / res1;
            //var res3 = Math.Pow(res2, x);
            //var res4 = Math.Sin(res3);
            //var res5 = Math.Sin(res4);

            //var res6 = Math.Sin(Math.Sin(Math.Pow(x / (x + 0.5), x)));

            k[i, j] = Math.Sin(Math.Sin(Math.Pow(x / (x + 0.5), x)));
        }
        else if (oddNumbers[i] == 5 || oddNumbers[i] == 7 || oddNumbers[i] == 11 || oddNumbers[i] == 15)
        {
            //var res1 = Math.Tan(2.0 * x);
            //var res2 = res1 + (2.0 / 3.0);
            //var res3 = 0.5 / res2;
            //var res4 = Math.Cbrt(Math.Cbrt(x));
            //var res5 = Math.Pow(Math.Abs(res3), res4); // Модуль, чтобы избежать комплексного числа

            //var res6 = Math.Pow(Math.Abs(0.5 / (Math.Tan(2.0 * x) + 2.0 / 3.0)), Math.Cbrt(Math.Cbrt(x)));

            k[i, j] = Math.Pow(Math.Abs(0.5 / (Math.Tan(2.0 * x) + 2.0 / 3.0)), Math.Cbrt(Math.Cbrt(x)));
        }
        else
        {
            //var res1 = (1.0 - x) / Math.PI;
            //var res2 = Math.Exp(res1);
            //var res3 = res2 / 12;
            //var res4 = Math.Tan(res3);
            //var res5 = Math.Pow(res4, 3);

            //var res6 = Math.Pow(Math.Tan(Math.Exp((1.0 - x) / Math.PI) / 12), 3);

            k[i, j] = Math.Pow(Math.Tan(Math.Exp((1.0 - x) / Math.PI) / 12), 3);
        }
    }
}

// Вывод массива
Console.WriteLine("\nЗадание #3");
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.WriteLine($"k[{i}, {j}]: {k[i, j]}");
    }
    Console.WriteLine();
}

//--------------------------------
//-----------Задание #3-----------
//--------------------------------