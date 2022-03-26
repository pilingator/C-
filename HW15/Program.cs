//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(0, 1000);
    }
    return answer;
}
void printArr(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine();
}

int[] arr = RandArray(12);
printArr(arr);
int count = 0;
void chet(int[] arr)
{


    for (int i = 0; i < 12; i++)
    {
        if (arr[i] % 2 == 0)
           
        count++;
    }

}
chet(arr);
Console.WriteLine($"Четных чисел в массиве {count}");