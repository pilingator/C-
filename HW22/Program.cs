// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 100);
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
double CalcArray(int[,] array)
{ 
    double res = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {   
         
        for (int i = 0; i < array.GetLength(0); i++)
        
        {   
            
            res += array[i, j];
            
        }
        Console.WriteLine($"Столбец {j} = {res / array.GetLength(0)}");
        res = 0;
    }
    return res; 
}

int[,] array = FillArray(5, 4);
PrintArray(array);
Console.WriteLine("Среднее арифметическое значение");
CalcArray(array);