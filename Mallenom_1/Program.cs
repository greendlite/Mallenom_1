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
            k[i, j] = Math.Sin(Math.Sin(Math.Pow(x / (x + 0.5), x)));
        }
        else if (oddNumbers[i] == 5 || oddNumbers[i] == 7 || oddNumbers[i] == 11 || oddNumbers[i] == 15)
        {
            var value = Math.Tan(2 * x) + 2.0 / 3.0;
            if (value != 0)
            {
                k[i, j] = Math.Pow(0.5 / (Math.Tan(2 * x) + 2.0 / 3.0), Math.Pow(x, 1.0 / 9.0));
            }
            else
            {
                k[i, j] = 0;
            }
        }
        else
        {
            k[i, j] = Math.Tan(Math.Pow(Math.Pow(Math.E, (1 - x) / Math.PI) / 12, 3));
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
        Console.Write(k[i, j] + " ");
    }
    Console.WriteLine();
}