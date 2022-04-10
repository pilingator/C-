// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
void PrintN(int N,int i)
{
    if(i > N) return; 
    Console.Write(i + " ");
    PrintN(N,i+1);  
}
int Sum(int A, int B)
{
    if(B == A) return A;
    return A + Sum(A + 1, B); 
}
int M = Prompt("Введите число => ");
int N = Prompt("Введите число => ");
PrintN(N,M);
Console.WriteLine();
Console.WriteLine($"Сумма элементов от {M} до {N} равна {Sum(M, N)}");