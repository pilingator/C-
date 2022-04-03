// Задача 4: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(5, 100);
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

int[,] minimum(int[,] array)
{   int x = 0;
    int y = 0;
    int min = array[0, 0]; 
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
   {
        if (min > array[i, j])
        {
            min = array[i, j];
            x = i;
            y = j;
            
        }  
        
    }
    Console.WriteLine($"Минимальное число массива {min} находится на {x} строке в {y} столбце");
    Console.WriteLine("Вывод преобразованной матрицы");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        {
            if ((i == x) || (j == y))
                continue;
            else
                Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine();
}
    return array;
}

int[,] array = FillArray(5, 5);
PrintArray(array);
minimum(array);








