// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)        
            Console.Write($" {arr[i, j], 4} ");        
        Console.WriteLine();       
    }
    Console.WriteLine();
}

int[,] RandArr(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)      
        for (int j = 0; j < column; j++)        
            arr[i, j] = new Random().Next(0, 10);                
    
    return arr;
}

int[,] RotationArr(int[,] old_arr, int row, int column) 
{
    int[,] arr = new int[column, row];

    for (int i = 0; i < column; i++)      
        for (int j = 0; j < row; j++)        
            arr[i, j] = old_arr[j, i];                
    
    return arr;
}

void AverageColumns(int[,] arr) {
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        double sum = 0;
        for (int j = 0; j < column_size; j++)        
            sum += arr[i, j];        
        Console.Write($"{Math.Round(sum / column_size, 1), 4} ");       
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] array = RandArr(row_num, column_num);
Print(array);
int[,] rot_array = RotationArr(array, row_num, column_num);

AverageColumns(rot_array);
