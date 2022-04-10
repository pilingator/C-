// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в 
// промежутке от M до N.
// M = 1; N = 5. -> "2, 4"
// M = 4; N = 8. -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
void Printchetn(int N,int i)
{
    if(i > N) return; 
    if(i % 2 == 0)
    Console.Write(i + " ");
    Printchetn(N,i+1);  
}
int M = Prompt("Введите число => ");
int N = Prompt("Введите число => ");
Printchetn(N,M);
