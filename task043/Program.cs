// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
double[,] сoefficient = new double[2, 2];

void InputCoefficients()
{
    for (int i = 0; i < сoefficient.GetLength(0); i++)
    {
        Console.Write($"Введите коэффициенты {i + 1}-го уравнения (y = k * x + b):\n");
        for (int j = 0; j < сoefficient.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"Введите коэффициент k: ");
            else Console.Write($"Введите коэффициент b: ");
            сoefficient[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] crossPoint = new double[2];

double[] IntersectionPoint(double[,] coeff)
{
    crossPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    crossPoint[1] = crossPoint[0] * coeff[0, 0] + coeff[0, 1];
    return crossPoint;
}

void OutputConditions(double[,] direct)
{
    if (direct[0, 0] == direct[1, 0] && direct[0, 1] == direct[1, 1])
    {
        Console.Write($"\nПрямые совпадают\n");
    }
    else if (direct[0, 0] == direct[1, 0] && direct[0, 1] != direct[1, 1])
    {
        Console.Write($"\nПрямые параллельны/n");
    }
    else
    {
        IntersectionPoint(direct);
        Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})\n");
    }
}

InputCoefficients();
OutputConditions(сoefficient);