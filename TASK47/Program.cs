// Задача 3: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел 
// (без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива 
// info. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом 
// информации из массива info.

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] result = new int[info.Length];
int k = 0; // счетчик количества цифр в data
for (int i = 0; i < info.Length; i++) //разбиваем data на числа в двоичном коде на основе количества бит из info
{
    for (int j = 0; j < info[i]; j++)
    {
        Console.Write(data[k + j] + " ");
    }
    k += info[i];
    Console.Write("; ");
}

k = 0;
for (int i = 0; i < info.Length; i++) // преобразуем получившиеся числа из 2-ой в 10-ую
{
    for (int j = 0; j < info[i]; j++)
    {
        result[i] += data[k + j] * (int)Math.Pow(2, info[i] - 1 - j);
    }
    k += info[i];
}
Console.WriteLine();
for (int i = 0; i < result.Length; i++)
{
    Console.Write(result[i] + " ");
}

