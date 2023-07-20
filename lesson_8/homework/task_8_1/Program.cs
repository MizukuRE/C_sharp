// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

void MinSumInRow(int[,] array) {
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int[] sums = new int[rows];

    for (int i = 0; i < rows; i++) {
        sums[i] = 0;

        for (int j = 0; j < columns; j++)
            sums[i] += array[i, j];
    }

    int min = sums[0];
    int result = 0;
    for (int i = 1; i < rows; i++) {
        if (sums[i] < min) {
            min = sums[i];
            result = i + 1;
        }
    }
    
    Console.WriteLine($"Минимальная сумма элементов в строке: {result}");
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите начало интервала значений: ");
int begin = int.Parse(Console.ReadLine()!);
Console.Write("Введите конец интервала значений: ");
int end = int.Parse(Console.ReadLine()!);

int[,] array = RandArr(rows, columns, begin, end);
PrintArr(array);
Console.WriteLine();
MinSumInRow(array);
