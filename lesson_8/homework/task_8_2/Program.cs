// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] RandArr(int rows, int columns, int begin, int end) {
    int[,] arr = new int[rows, columns];

    for (int i = 0; i < rows; i++) 
        for (int j = 0; j < columns; j++)
            arr[i, j] = new Random().Next(begin, end + 1);
    
    return arr;
}

void PrintArr(int[,] array) {
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++) {
        for(int j = 0; j < columns; j++)
            Console.Write($"{array[i, j], 4}");

        Console.WriteLine();
    }
}

int[,] MatrixComposition(int[,] arrayA, int[,] arrayB) {
    int rowsA = arrayA.GetLength(0);
    int columnsA = arrayA.GetLength(1);
    int columnsB = arrayB.GetLength(1);

    int[,] resultArr = RandArr(rowsA, columnsB, 0, 0);
    for (int i = 0; i < rowsA; i++) {
        for (int j = 0; j < columnsB; j++) {
            for (int k = 0; k < columnsA; k++) {
                resultArr[i, j] += arrayA[i, k] * arrayB[k, j];
            }
        }
    }

    return resultArr;
}

Console.Write("Введите количество строк для первой матрицы: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для первой матрицы: ");
int columnsA = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало интервала значений для первой матрицы: ");
int beginA = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец интервала значений для первой матрицы: ");
int endA = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество строк для второй матрицы: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов для второй матрицы: ");
int columnsB = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало интервала значений для второй матрицы: ");
int beginB = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец интервала значений для второй матрицы: ");
int endB = int.Parse(Console.ReadLine()!);

if (columnsA != rowsB) {
    Console.WriteLine("Нельзя перемножить!");
        
    return;
}

int[,] arrayA = RandArr(rowsA, columnsA, beginA, endA);
int[,] arrayB = RandArr(rowsB, columnsB, beginB, endB);
PrintArr(arrayA);
Console.WriteLine();
PrintArr(arrayB);
Console.WriteLine();
int[,] arrayComp = MatrixComposition(arrayA, arrayB);
PrintArr(arrayComp);
