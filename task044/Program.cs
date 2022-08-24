// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


Console.Clear();
Console.Write("Введите первые 'N' чисел Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine($"\nКоличество чисел Фибоначчи: {N}\n");

int[] GetFibonacci(int N)
{
    int firstNumber = 0;
    int secondNumber = 1;
    int[] fibonacciNumbers = new int[N];
    fibonacciNumbers[0] = 0;
    fibonacciNumbers[1] = 1;
    for (int i = 1; i < N; i++)
    {
        fibonacciNumbers[i] = firstNumber + secondNumber;
        secondNumber = firstNumber;
        firstNumber = fibonacciNumbers[i];
    }
    return fibonacciNumbers;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    //Console.WriteLine();
}

Console.Write($"\n{N}! = ");
PrintArray(GetFibonacci(N));
Console.WriteLine();