//Задача 4: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-100, 100);
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

//int len = arr.Length(); 

void Exist(int[] arr)
{


    for (int i = 0; i < 12/2; i++)
    {
        
       // proizv = arr[i] * arr[len - i - 1];
        Console.WriteLine($"{arr[i] * arr[12 - i - 1]} ");
            
    }

}

Exist(arr);
