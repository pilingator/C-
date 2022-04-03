// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");


        }
        Console.WriteLine();
    }
}

int CalcArray(int[,] array)

{
    int res = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
            if (i == j) res = res + array[i, j];
        }
           
    }
    return res; 
}

int[,] array = FillArray(4, 4);
PrintArray(array);
Console.WriteLine(CalcArray(array));