// Задача 1: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.

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

int[,] CalcArray(int[,] array)
{ 
    

    {
        for (int j = 0; j < array.GetLength(1); j++)
        
        {   
            int temp = 0;
            temp = array[0, j];
            array[0, j] = array[array.GetLength(0) - 1, j];
            array[array.GetLength(0) - 1, j] = temp;

            
        }
        
    }
    return array; 
}

int[,] array = FillArray(5, 4);
PrintArray(array);
CalcArray(array);
Console.WriteLine();
PrintArray(array);
