// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих. 
// 3 и 4, N = 5 -> 3 4 7 11 18
// 6 и 10, N = 4 -> 6 10 16 26 

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void PrintArray(int[] collect)
{
    Console.Write("[");
    for (int i = 0; i < collect.Length - 1; i++)
    {
        Console.Write(collect[i] + ",");
    }
    Console.WriteLine(collect[collect.Length - 1] + "]");
}

int N = Promt("Введите число N => ");
int M = Promt("Введите первое число => ");
int O = Promt("Введите второе число => ");

int[] K = new int[N];
K[0] = M;
K[1] = O;
for (int i = 2; i < N; i++)
{
    K[i] = K[i - 1] + K[i - 2];
}
PrintArray(K);

Sum(M, O, N);
int Sum(int M, int O, int N){
    if(N < 1) return 0;
    Console.WriteLine(M);
    int P = M + Sum(O, M + O, N - 1);
    return P;
}