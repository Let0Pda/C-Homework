// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
//стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
int count = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
}

for (int i = 1; i < array.Length; i++)
{
    if (i % 2 > 0) count += array[i];
    
}

Console.WriteLine();
Console.Write('[' + string.Join(", ", array) + ']');
Console.WriteLine($" -> {count}\n");
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {count}\n");