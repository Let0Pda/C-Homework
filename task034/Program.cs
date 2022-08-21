// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int count = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 1000);
}

for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] % 2 == 0)
    {
        count = count + 1;
        
    }
        
}

Console.Write('[' + string.Join(", ", array) + ']');
Console.WriteLine($" -> {count}\n");
Console.WriteLine($"Кол-во чётных чисел в массиве = {count}\n");