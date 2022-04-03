// Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] FillArray(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10,10) + rnd.NextDouble();
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j] = Math.Round(array[i, j], 1)}\t");
        }
        Console.WriteLine();
    }
}

double[,] array = FillArray(3, 4);
PrintArray(array);