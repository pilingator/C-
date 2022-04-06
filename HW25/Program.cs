// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void FillArray(int[, ] array, int[, ] array1) {
	for (int i = 0; i < array.GetLength(0); i++) {
		for (int j = 0; j < array.GetLength(1); j++) {
			array[i, j] = new Random().Next(1, 10);
		}
	}
	for (int i = 0; i < array.GetLength(0); i++) {
		for (int j = 0; j < array.GetLength(1); j++) {
			array1[i, j] = new Random().Next(1, 10);
		}
	}
}
void PrintArray(int[, ] array, int[, ] array1) {
	for (int i = 0; i < array.GetLength(0); i++) {
		for (int j = 0; j < array.GetLength(1); j++) {
			Console.Write($"{array[i, j]}\t");
		}
		Console.WriteLine();
	}
	for (int i = 0; i < array.GetLength(0); i++) {
		for (int j = 0; j < array.GetLength(1); j++) {
			Console.Write($"{array1[i, j]}\t");
		}
		Console.WriteLine();
	}
}
void Composition(int[, ] array, int[, ] array1, int[, ] compArray) {
	for (int i = 0; i < array.GetLength(0); i++) {
		for (int j = 0; j < array.GetLength(1); j++) {
			compArray[i, j] = array[i, j] * array1[i, j];
		}
	}
}
void PrintCompArray(int[, ] compArray) {
	for (int i = 0; i < compArray.GetLength(0); i++) {
		for (int j = 0; j < compArray.GetLength(1); j++) {
			Console.Write($"{compArray[i, j]}\t");
		}
		Console.WriteLine();
	}
}
int[, ] array = new int[5, 5];
int[, ] array1 = new int[5, 5];
int[, ] compArray = new int[5, 5];
FillArray(array, array1);
PrintArray(array, array1);
Composition(array, array1, compArray);
Console.WriteLine();
PrintCompArray(compArray);