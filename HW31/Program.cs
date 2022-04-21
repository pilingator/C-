// Задача 2: Проверка на простое число: 
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

void SimpleDigit(int N, int K)
{
    
    if (N / K == 1)
    {
        Console.WriteLine("Является простым числом");
    return;
    }
    if (N % K != 0)
    {
       
        SimpleDigit(N, K + 1);
    }
    else Console.WriteLine("Не является простым числом");
}

Console.WriteLine("Введите N: ");
var n = int.Parse(Console.ReadLine());
SimpleDigit(n, 2);
