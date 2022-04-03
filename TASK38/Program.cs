// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
    for (int i = 0; i < array.GetLength(0); i++)

    {
        for (int j = 0; j < i; j++)
        
        {   
            int temp = 0;
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;

        }
        
    }
    return array; 
}

int[,] array = FillArray(5, 5);
PrintArray(array);
CalcArray(array);
Console.WriteLine();
PrintArray(array);
