// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.


Console.WriteLine("Введите двумерный массив m*n");
Console.Write("\nВведите m -> ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите n -> ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
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
Console.WriteLine();

int indexRow = matrix.GetLength(0) - 1;
int indexCol = matrix.GetLength(1) - 1;

void PrintMatrix(int[,] matrix) //распечатывает матрицу
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FindMinElement(int[,] matrix)
{
    int min = matrix[0, 0];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexRow = i;
                indexCol = j;
            }

        }

    }


}

int[,] DeleteNewMatrix(int[,] matrix, int indexRaw, int indexCol)
{
    int[,] matrixNew1 = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i - indexRaw > 0 && j - indexCol > 0)
            {
                matrixNew1[i - 1, j - 1] = matrix[i, j];
            }
            else if (i - indexRaw > 0 && j - indexCol < 0)
            {
                matrixNew1[i - 1, j] = matrix[i, j];
            }
            else if (i - indexRaw < 0 && j - indexCol > 0)
            {
                matrixNew1[i, j - 1] = matrix[i, j];
            }
            else if (i - indexRaw < 0 && j - indexCol < 0)
            {
                matrixNew1[i, j] = matrix[i, j];
            }
        }
    }
    return matrixNew1;
}


Console.WriteLine();


FindMinElement(matrix);
Console.Write($"Найдено минимальное значение в массиве ->  {matrix[indexRow, indexCol]} с индексами i = {indexRow}, j = {indexCol}");
int[] minPosition = new int[matrix[indexRow, indexCol]];
Console.WriteLine("\nНовый массив:\n");
PrintMatrix(DeleteNewMatrix(matrix, indexRow, indexCol));
