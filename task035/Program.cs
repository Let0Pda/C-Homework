// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

int[] array = new int[123];
int count = 0;
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-100, 100);
}
Console.Write('[' + string.Join(", ", array) + ']');

for (int i = 0; i < array.Length; i++)
    {
        //System.Console.Write(array[i] + " ");
        if (array[i] >= 10 && array[i] <= 99) count++;
    }

Console.WriteLine($" -> {count}\n");
Console.WriteLine($"Количество чисел из диапазона [10, 99] равно {count}");
Console.WriteLine();