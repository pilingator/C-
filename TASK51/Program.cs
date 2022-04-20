// Задача 4: Разверните число при помощи рекурсии: N = 1234 -> "4321"
int ReversNumber(int N, int k = 0)
{
if(N == 0)
{
    Console.WriteLine(k);
    return k;
}

return ReversNumber(N/10, k * 10 + N % 10);
}
Console.WriteLine("Введите N: ");
var n = int.Parse(Console.ReadLine());
ReversNumber(n);