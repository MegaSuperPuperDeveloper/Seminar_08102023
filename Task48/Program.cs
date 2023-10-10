// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n,
// Выведите полученный массив на экран.
//  m = 3, n = 4.
//  0 1 2 3
//  1 2 3 4
//  2 3 4 5

int[,] CreateMatrixSumIndexes(int[,] arr) { // Функция заполняет массив в соотв. с формулой Amn = m + n.
    for(int i = 0; i < arr.GetLength(0); i++) {
        Console.Write("|");
        for(int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = i + j;
            Console.Write($" {arr[i, j], 6}");
        }
        Console.Write("      |");
        Console.WriteLine();
    }
    return arr;
}

Console.Write("Введите количество строчек в таблице: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в таблице: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
Console.WriteLine($"m = {m}, n = {n}.");
CreateMatrixSumIndexes(array);