// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
int SumN(int N)
{
    if(N/10 <= 0 ) return N%10 ;
    return N%10 + SumN(N/10);
}
int N = Prompt("Введите число => ");
Console.WriteLine(SumN(N));
