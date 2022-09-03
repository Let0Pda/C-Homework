// Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника



Console.Clear();
Console.Write("Введите количество строк треугольника Паскаля: ");
int indexRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n");
int weСonsider(int row)
{
    int res = 1;
    for(int i = 1; i <= row; i++)
    {
        res*=i;
    }
    return res;
}


for(int i = 0; i < indexRow; i++)
{
    for(int j = 0; j <= (indexRow - i); j++)  
    {
        Console.Write(" ");
    }
    for(int j = 0; j <= i; j++)
    {
        Console.Write(" ");
        Console.Write(weСonsider(i) / (weСonsider(j) * weСonsider(i - j)));
    }
    Console.WriteLine();
}

Console.WriteLine("\n");