// Напишите программу, которая задаёт массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)
void FindArray(int[] arr)
{
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(); 
    }
}
void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ",");

    }
    Console.WriteLine(collect[7] + "]");
}
int[] arr = new int[8];

FindArray(arr);
PrintArray(arr);