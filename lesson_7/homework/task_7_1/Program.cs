// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

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
            arr[i, j] = new Random().Next(-9, 10);                
    
    return arr;
}

void SearchEl(int[,] arr, int row, int column)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    if (row > row_size || column > column_size || row <= 0 || column <= 0) {
        Console.WriteLine("Данной позиции нет в массиве");
        
        return;
    }
    
    Console.WriteLine($"{arr[row - 1, column - 1], 4}");
}

Console.Write("Enter the amount of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the amount of columns: ");
int column_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of row: ");
int row = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of column: ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = RandArr(row_num, column_num);
Print(array);
SearchEl(array, row, column);
