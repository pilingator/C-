// Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

Console.WriteLine("Введите первое число => ");
string numberA = Console.ReadLine();
double A = int.Parse(numberA);

Console.WriteLine("Введите второе число число => ");
string numberB = Console.ReadLine();
double B = int.Parse(numberB);

double proizv = 1; 

for(int i = 1; i <= B; i++)
{
    proizv = proizv*A;
}

Console.WriteLine($"Число {A} в степени {B} равно {proizv}");