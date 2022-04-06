// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[, ] FillArray(int row, int column) {
	int[, ] array = new int[row, column];
	Random rnd = new Random();
	for (int i = 0; i < array.GetLength(0); i++) {
		for (int j = 0; j < array.GetLength(1); j++) {
			array[i, j] = rnd.Next( - 10, 100);
		}
	}
	return array;
}

void PrintArray(int[, ] array) {
	for (int i = 0; i < array.GetLength(0); i++) {
		for (int j = 0; j < array.GetLength(1); j++) {
			Console.Write($"{array[i, j]}\t");
		}
		Console.WriteLine();
	}
}
int CalcArray(int[, ] array) {
	int sum = 0;
	int minSum = 0;
	int minNum = 0;
	for (int i = 0; i < array.GetLength(0); i++) {

		for (int j = 0; j < array.GetLength(1); j++)

		{
			if (i == 0) {
				sum += array[i, j];
				minSum += array[i, j];
			}
			else sum += array[i, j];

		}

		if (sum < minSum) {
			minSum = sum;
			minNum = i;
		}

		Console.WriteLine($"Строка {i} = {sum}");

		sum = 0;
	}
	Console.WriteLine($"Строка {minNum} с минимальным значением суммы элементов");
	return minNum;

}

int[, ] array = FillArray(5, 4);
Console.WriteLine("Исходный массив");
PrintArray(array);
Console.WriteLine("Сумма элементов строк");
CalcArray(array);