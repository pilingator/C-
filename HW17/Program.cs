//Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
//элементов массива.
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(0, 100);
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

int max = 0;
int min = arr[0];
void maximum(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > max)
        {
            max = arr[i];
        }  
        
    }

}
void minimum(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }  
        
    }

}
minimum(arr);
maximum(arr);

Console.WriteLine($"Максимальное число массива {max}");
Console.WriteLine($"Минимально число массива {min}");
Console.WriteLine($"Разность максимального и минимального {max - min}");
