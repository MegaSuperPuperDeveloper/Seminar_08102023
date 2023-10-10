// Задача 49: Задайте двумерный массив. Найдите элементы, 
// у которых оба индекса чётные, и замените эти элементы на их 
// квадраты.

void PrintMatrix(int[,] matrix1) { // Выводит двумерный массив.
    for(int i = 0; i < matrix1.GetLength(0); i++) {
        Console.Write("|");
        for(int j = 0; j < matrix1.GetLength(1); j++) {
            Console.Write($" {matrix1[i, j], 6}");
        }
        Console.Write("      |");
        Console.WriteLine();
    }
}

int[,] PullArray(int[,] matrix2) { // Заполняет массив случайными числами.
    var rnd = new Random();
    for(int i = 0; i < matrix2.GetLength(0); i++) {
        for(int j = 0; j < matrix2.GetLength(1); j++) {
            matrix2[i, j] = rnd.Next(1, 20);
        }
    }
    return matrix2;
}

int[,] SquareOfEvenIndexes(int[,] matrix) { // Заменяет элементы массива на квадрат элемента если четный индекс.
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
            if(i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
        }
    }
    return matrix;
}

var m = new Random().Next(2, 10);
var n = new Random().Next(2, 10);
int[,] matrix = new int[m, n];
PullArray(matrix);
PrintMatrix(matrix);
Console.WriteLine();
SquareOfEvenIndexes(matrix);
PrintMatrix(matrix);