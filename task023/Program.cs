/* Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.Clear();
Console.WriteLine("Задача 23");
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
void Cube(int[] N)
{
    int count = 0;
    int length = N.Length;
    while (count < length)
    {
        N[count] = Convert.ToInt32(Math.Pow(count, 3));
        count++;
    }
}
void PrintArry(int[] coll)
{
    int result = coll.Length;
    int index = 1;
    while (index < result)
    {
        Console.Write(coll[index] + " ");
        index++;
    }
}
if (N >= 1)
{

    int[] arry = new int[N + 1];
    Cube(arry);
    PrintArry(arry);
}
else
{
    Console.Write("Введите правильное число: ");
}
Console.WriteLine();
