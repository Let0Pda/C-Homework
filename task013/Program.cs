/* 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Clear();
Console.WriteLine("Задача 13 ");
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
number = Math.Abs(number);
//Console.WriteLine(number); // Это проверка для отрицательного числа
string numberText = Convert.ToString(number);
if (numberText.Length > 2)
{
    Console.WriteLine("Третья цифра числа: " + numberText[2]);
}
else
{
    Console.WriteLine("У числа нет третьей цифры.");
}