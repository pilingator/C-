// адача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в 
// промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

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
int N = Prompt("Введите число => ");
PrintN(N,1);
