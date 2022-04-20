// Задача 1: Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
// какое значение этого числа: 1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... Выведите ряд этой последовательности 
// до N-го значения, желательно использовать : N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"
void PrintNumber(int N, int k = 1, int m = 0)
{
    for (int i = 0; i < k; i++)
    {
        Console.Write(k + " ");
        m++;
        if (m == N)
        return;
    }
    PrintNumber(N, k + 1, m);
}
Console.WriteLine("Введите N: ");
var n = int.Parse(Console.ReadLine());
PrintNumber(n);

