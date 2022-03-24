// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число => ");
string inputNumber = Console.ReadLine();
int N = int.Parse(inputNumber);
int i = 0;
int sum = 0;
while(N > 0)
{
    sum = sum + (N % 10);
    N = N / 10;
    i++;
}
Console.WriteLine($"Сумма цифр в числе {inputNumber} равно {sum} ");
