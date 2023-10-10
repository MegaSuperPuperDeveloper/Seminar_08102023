// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами)
// (0,0); (1,1) и т.д.

void PrintResult(int[,] matrix) {
    Console.Write($"Сумма элементов главной диагонали: ");
    for(int m = 0; m < matrix.GetLength(0); m++) {
        for(int n = 0; n < matrix.GetLength(1); n++) {
            if(m == n && n != matrix.GetLength(0) - 1) {
                Console.Write($"{matrix[m, n]} + ");
            } else if(m == n && n == matrix.GetLength(1) - 1) {
                Console.Write($"{matrix[m, n]} = ");
            }
        }   
    }
}

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

int SumOfDiagonal(int[,] matrix) { // Возвращает сумму элементов по диагонали
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++) {
            if(i == j) {
                sum += matrix[i, j];

            }
        }
    }
    return sum;
}

var m = new Random().Next(2, 10);
var n = new Random().Next(2, 10);

int[,] matrix = new int[m, n];
PullArray(matrix);
PrintMatrix(matrix);
int sum = SumOfDiagonal(matrix);
PrintResult(matrix);
Console.Write(sum);