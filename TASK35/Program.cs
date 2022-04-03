﻿//Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
//выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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

void CalcArray(int[,] array, int Value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == Value)
            {
                Console.WriteLine($"Элемент найден в строке {i}, столбец{j}");

                return;
            }
            
        }
    }
    Console.WriteLine("Элемент не найден");
}

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

int[,] array = FillArray(5, 4);
PrintArray(array);
Console.WriteLine();

int Value = Prompt("Введите число ");

CalcArray(array, Value);
