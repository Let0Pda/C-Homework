/* Дополнительная задача (необязательная)
Задача 28*: Напишите программу, в которой задается массив чисел(ввод может быть с клавиатуры, либо можете сами задавать массив чисел) 
и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.
{2, 3, 4} -> 2, 6, 24
{5, 3, 6, 2, 5, 1} -> 6, 720, 2, 120, 1
*/
Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];
for (int i = 0; i < N; i++)
{
    Console.Write($"\nВведите {i +1 }й элемент массива: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int res = 0;
Console.WriteLine();
int Resalt(int i)
{
    if (i == 1) return 1;
 
    return i * Resalt(i - 1);
}
for (int j = 0; j < N; j++)
{
    res = Resalt(array[j]);

    Console.WriteLine($"Индекс = [{j}]\n Произведение чисел от 1 до {array[j]} = {res}.\n");
}
