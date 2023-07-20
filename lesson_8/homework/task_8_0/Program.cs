// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortRows(int[,] array) {
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int k = 0; k < columns - j - 1; k++)
                if (array[i, k] < array[i, k + 1])
                    (array[i, k], array[i, k + 1]) = (array[i, k + 1], array[i, k]);

    return array;
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
int[,] sortedArr = SortRows(array);
PrintArr(sortedArr);
