//Задача 2: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да


int[] RandArray(int lenght)
{
    int[] answer = new int[lenght];
    for (int i = 0; i < lenght; i++)
    {
        answer[i] = new Random().Next(-9, 10);
    }
    return answer;
}
void printArr(int[] Mas)
{
    int count = Mas.Length;
    for (int pos = 0; pos < count; pos++)
    {
        Console.Write(Mas[pos] + " ,");
    }
    Console.WriteLine();
}


int[] arr = RandArray(5);
printArr(arr);
Console.WriteLine("Введите первое число => ");
string numberA = Console.ReadLine();
int A = int.Parse(numberA);
bool Exist (int[] arr, int elem){


for(int i = 0; i < 5; i++)
{
    if (arr[i] == A)
    return true;
}  
return false;
}  
if (Exist(arr, A))    
Console.WriteLine("да");
   
else

Console.WriteLine("нет");



