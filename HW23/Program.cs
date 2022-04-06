// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
// элементы каждой строки двумерного массива.

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

int[, ] CalcArray(int[, ] array) {
	for (int i = 0; i < array.GetLength(0); i++)

	{
		for (int j = 0; j < array.GetLength(1); j++)

		{
			for (int k = 0; k < array.GetLength(1) - j - 1; k++) // цикл для сравнения и обмена
			{

				if (array[i, k] < array[i, k + 1]) {
					int temp = 0;
					temp = array[i, k];
					array[i, k] = array[i, k + 1];
					array[i, k + 1] = temp;
				}
			}
		}

	}
	return array;
}
int[, ] array = FillArray(5, 5);
Console.WriteLine("Исходный массив");
PrintArray(array);
CalcArray(array);
Console.WriteLine("Отсортированный массив (каждая стока по убыванию)");
PrintArray(array);



