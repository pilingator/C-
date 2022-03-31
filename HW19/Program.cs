// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Поиск точки пересечения двух прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("Введите b1 число => ");
string numberA = Console.ReadLine();
double b1 = double.Parse(numberA);

Console.WriteLine("Введите k1 число => ");
string numberB = Console.ReadLine();
double k1 = double.Parse(numberB);

Console.WriteLine("Введите b2 число => ");
string numberC = Console.ReadLine();
double b2 = double.Parse(numberC);

Console.WriteLine("Введите k2 число => ");
string numberD = Console.ReadLine();
double k2 = double.Parse(numberD);

double x = 0;
double y = 0; 
x = ((b2 - b1) / (k1 - k2)); 
y = ((k1 * ((b2 - b1) / (k1 - k2))) + b1);

Console.WriteLine($"Точка пересечения данных прямых х = {x}, y = {y}");