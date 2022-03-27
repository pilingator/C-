//Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(0, 5);
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


int sumEl(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
           
        sum += arr[i];
    }
    return sum;
}

Console.WriteLine($"Сумма нечетных элементов массива: {sumEl(arr)}");
