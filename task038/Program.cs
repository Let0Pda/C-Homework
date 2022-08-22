// Задача 38: Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] arrayRealN = new double[N];

for (int i = 0; i < N; i++)
{
    Console.Write($"\nВведите {i + 1}й элемент массива:\t"); // {N,n}
    arrayRealN[i] = double.Parse(Console.ReadLine());
}
double max = arrayRealN[0];
double min = arrayRealN[0];

for (int i = 1; i < arrayRealN.Length; i++)
{
    if (max < arrayRealN[i])
    {
        max = arrayRealN[i];
    }
    if (min > arrayRealN[i])
    {
        min = arrayRealN[i];
    }
}

double differenceOfNumbers = max - min;

Console.WriteLine();
Console.Write('[' + string.Join(", ", arrayRealN) + ']');
Console.WriteLine($" -> {differenceOfNumbers}\n");
Console.WriteLine($"Разница между между максимальным ({max}) и минимальным({min}) элементами = {differenceOfNumbers}");