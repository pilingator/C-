// Задача 3: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
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

int[] CalcArray(int[,] array)
{ 
    int[] freq = new int[10];
    
    foreach (int elem in array)
{
    freq[elem]++;
            
    }
    return freq; 
}
void console(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.WriteLine(Mas[pos] + "- " + pos );
    }
    Console.WriteLine();
}

int[,] array = FillArray(5, 5);
PrintArray(array);
int[] result = CalcArray(array);
console(result);


