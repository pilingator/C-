// Задача 3: Разложите число на множители. Желательно использовать рекурсию: N = 12 -> "2, 2, 3"

void PrintNumber(int N, int k = 2)
{
    
    if (N/2 < k)
    {
        Console.WriteLine(N);
    return;
    }
    if (N % k == 0)
    {
        Console.WriteLine(k);
        PrintNumber(N/k, k);
    }
    else PrintNumber(N, k+1);
}
Console.WriteLine("Введите N: ");
var n = int.Parse(Console.ReadLine());
PrintNumber(n);
