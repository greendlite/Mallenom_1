// Задание - 1
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

// Задание - 2
double[] randomValues = new double[13];
var rangeMin = -12.0;
var rangeMax = 15.0;
Random rn = new();

for(int i = 0; i < randomValues.Length; i++)
{
    randomValues[i] = rangeMin + (rangeMax - rangeMin) * rn.NextDouble();
}

Console.WriteLine();
Console.WriteLine("Задание #2");
Console.Write("Массив: ");
foreach (var n in randomValues)
{
    Console.Write(n + ", ");
}
Console.WriteLine();