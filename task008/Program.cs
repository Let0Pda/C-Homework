﻿/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Clear();
Console.WriteLine("Задача 8");
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
//for (int i = 1; i <= n; i++)
for (int i = 2; i <= n; i += 2)

    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
