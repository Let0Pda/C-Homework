//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


Console.Clear();
int N = 8;
int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

Console.WriteLine('[' + string.Join(", ", SetArray(N)) + ']');