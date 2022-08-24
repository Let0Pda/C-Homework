//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-1000, 1000);
}
int[] copyArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    copyArray[i] = array[i];
}

Console.Write($"\nИсходный массив из {N} элемнтов ->\t");
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.Write($"\nСкопированный массив из {array.Length} элемнтов ->\t");
Console.WriteLine('[' + string.Join(", ", copyArray) + ']');