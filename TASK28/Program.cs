// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3  -> 11
//2  -> 10

int Promt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}
string Dvoichnaya(int number)
{
    string answer = " ";
    while (number > 0)
    {
        answer = number % 2 + answer;
        number = number / 2;
    }
    return answer;
}

int number = Promt("Введите десятичное число => ");
int temp = number;
string N = Dvoichnaya(number);
Console.WriteLine($"Число {temp} в двоичной системе => {N}");

