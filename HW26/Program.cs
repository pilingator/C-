// Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[, , ] FillArray(int row, int column, int column2) {
	int[, , ] array = new int[row, column, column2];
	Random rnd = new Random();
	for (int i = 0; i < array.GetLength(0); i++) {
		for (int j = 0; j < array.GetLength(1); j++) {
			for (int k = 0; k < array.GetLength(2); k++) {
				array[i, j, k] = rnd.Next(9, 100);
			}
		}

	}
	return array;
}

void PrintArray(int[, , ] array) {

	for (int i = 0; i < array.GetLength(0); i++)

	{
		Console.WriteLine();
		for (int j = 0; j < array.GetLength(1); j++) {
			Console.WriteLine();
			for (int k = 0; k < array.GetLength(2); k++) {
				Console.Write($"{array[i, j, k]}\t");
				Console.Write($"[{i},{j},{k}]\t");
			}
		}
		Console.WriteLine("");

	}
}
int[, , ] array = FillArray(3, 3, 3);
PrintArray(array);