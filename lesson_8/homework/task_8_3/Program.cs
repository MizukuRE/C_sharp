// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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

int[,] CrossCut(int[,] array) {
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int min = array[0, 0];
    int minRow = 0;
    int minCol = 0;

    for (int i = 0; i < rows; i++) {
        for (int j = 0; j < columns; j++) {
            if (array[i, j] < min) {
                min = array[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }

    int[,] cutArr = new int[rows - 1, columns - 1];
    int countI = 0;
    int countJ = 0;

    for (int i = 0; i < rows - 1; i++) {
        if (countI == minRow)
            countI++;
        
        for (int j = 0; j < columns - 1; j++) {
            if (countJ == minCol)
                countJ++;

            cutArr[i, j] = array[countI, countJ];
            countJ++;
        }
        countJ = 0;
        countI++;
    }  
    return cutArr;
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
int[,] arrCut = CrossCut(array);
PrintArr(arrCut);
