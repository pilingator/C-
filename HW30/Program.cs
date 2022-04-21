// Задача 1: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

void Stepen2(int N)
{
    
    if (N / 2 == 0)
    {
        Console.WriteLine("Является степенью числа 2");
    return;
    }
    if (N % 2 == 0)
    {
       
        Stepen2(N/2);
    }
    else Console.WriteLine("Не является степенью числа 2");
}

Console.WriteLine("Введите N: ");
var n = int.Parse(Console.ReadLine());
Stepen2(n);