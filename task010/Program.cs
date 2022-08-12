/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

Console.Clear();
Console.WriteLine("Задача 10 ");
Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
if (number > 100 && number < 1000)
{

    string Snumber = Convert.ToString(number);
    Console.WriteLine("вторая цифра числа -> " + Snumber[1]);

}

else
{
    Console.WriteLine("Не трёхзначное число: ");

}
