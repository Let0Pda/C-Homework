// Дополнительная задача на рекурсию
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (использовать рекурсию)
// 4 -> 24
// 5 -> 120


Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
double x = 1;


int Resalt(int i)
{
    if (i == 1) return 1;

    return i * Resalt(i - 1);
}

// for (int i = 1; i <= N; i++)
// {
//     Console.WriteLine($"{i} -> {Resalt(i)}");
// }


Console.WriteLine($"Произведение чисел от 1 до {N} = {Resalt(N)}");
// Console.WriteLine();