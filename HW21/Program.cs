// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int[,] array = FillArray(5, 4);
PrintArray(array);

Console.WriteLine("Введите номер элемента строки => ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);

Console.WriteLine("Введите номер элемента столбца => ");
string numberB = Console.ReadLine();
int B = int.Parse(numberB);

if (A >= array.GetLength(0) || B >= array.GetLength(1)) 
Console.WriteLine("Такого элемента в массиве нет");
else
Console.WriteLine($"Элемент с указанной позиции {array[A, B]}");
