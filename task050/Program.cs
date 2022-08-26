// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет


Console.Clear();
int m = 3;
int n = 4;

Console.Write($"\nСоздан двумерный массив размера 'm = {m}' на 'n = {n}':\n");
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("\nВведите координаты позиции элемента, разделенных запятой: ");

string positionElement = Convert.ToString(Console.ReadLine());
RemovingSpaces(positionElement);
int[] position = Parser(positionElement);

if (position[0] <= m
    && position[1] <= n
    && position[0] >= 0
    && position[1] >= 0)
{
    double result = matrix[position[0], position[1]];   // Не очень понятно, как задают позицию, видимые или реальные индексы? 
                                                        //Возможно и так "double result = matrix[position[0] -1, position[1] -1];"
    Console.Write($"\nЗначение элемента: {result}\n");
}
else Console.Write($"\nТакого элемента в массиве нет.\n");

int[] Parser(string input)
{
    int countNum = 1;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] == ',' && i <= 2)
            countNum++;
    }

    int[] numbers = new int[countNum];
    int numberIndex = 0;
    for (int i = 0; i < input.Length; i++)
    {
        string subString = String.Empty;

        while (input[i] != ',')
        {
            subString += input[i].ToString();
            if (i >= input.Length - 1)
                break;
            i++;
        }
        numbers[numberIndex] = Convert.ToInt32(subString);
        numberIndex++;
    }
    return numbers;
}

string RemovingSpaces(string input)
{
    string output = String.Empty;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] != ' ')
        {
            output += input[i];
        }
    }
    return output;
}
