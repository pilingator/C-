// Задача 2: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

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
int M = Prompt("Введите число => ");
int N = Prompt("Введите число => ");
PrintN(N,M);
