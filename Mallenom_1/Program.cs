// Задание #1
int a = 5;
int b = 19;

List<int> lst = new();

for (int i = a; i <= b; i += 2)
{
    lst.Add(i);
}

int[] oddNumbers = lst.ToArray();

Console.WriteLine("Задание #1");
Console.Write("Массив: ");
foreach (var n in oddNumbers)
{
    Console.Write(n + ", ");
}
Console.WriteLine();

// Задание #2
double[] randomValues = new double[13];
var rangeMin = -12.0;
var rangeMax = 15.0;
Random rn = new();

for (int i = 0; i < randomValues.Length; i++)
{
    randomValues[i] = rangeMin + (rangeMax - rangeMin) * rn.NextDouble();
}

Console.WriteLine("\nЗадание #2");
Console.Write("Массив: ");
foreach (var n in randomValues)
{
    Console.Write(n + ", ");
}
Console.WriteLine();

// Задание #3
double[,] k = new double[8, 13];

for (int i = 0; i < 8; i++)
{
    for (int j = 0; j < 13; j++)
    {
        var x = randomValues[j];
        if (oddNumbers[i] == 9)
        {
            k[i, j] = Math.Sin(Math.Sin(Math.Pow(x / (x + 0.5), x)));
        }
        else if (oddNumbers[i] == 5 || oddNumbers[i] == 7 || oddNumbers[i] == 11 || oddNumbers[i] == 15)
        {
            
        }
        else
        {

        }
    }
}