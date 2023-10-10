// Задача 46: Задайте двумерный массив размеров mxn, 
// заполненный случайными целыми числами.

int[,] Table(int[,] matrix) { // Функция выводит случайные числа с m строками и n столбцами.
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++) {
        Console.Write("|");
        for(int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = rnd.Next(-10, 100);
            Console.Write($" {matrix[i, j], 6}");
        }
        Console.Write("      |");
        Console.WriteLine();
    }
    return matrix;
}

Console.Write("Введите количество строчек в таблице: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в таблице: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
Table(matrix);