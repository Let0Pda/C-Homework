﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("\nВведите число M -> ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N -> ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int Sum(int m, int n)
{
    if (m == n)
    {
        return m;
    }
    return m + Sum(m + 1, n);
}
Console.WriteLine(Sum(M, N));