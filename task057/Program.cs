// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, 
// сколько раз встречается элемент входных данных

Console.WriteLine("Введите двумерный массив m*n");
Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
void MatrixElement(int[,] matrix)
{

    int[] count = new int[10];
    for (int i = 0; i < m; i++)
    {

        for (int j = 0; j < n; j++)
        {
            count[matrix[i, j]]++;
        }
    }
    for (int l = 0; l <= 9; l++)
    {
        if (count[l] != 0)
        {
            Console.WriteLine($"Число {l} встречается {count[l]} раз \n");
        }
    }
}
MatrixElement(matrix);
