// 1. Задайте двумерный массив. Напишите программу,
//    которая поменяет местами первую и последнюю строку массива.

void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)        
            Console.Write($" {arr[i, j], 2} ");        
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

void SwapRows(int[,] arr) 
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int j = 0; j < column_size; j++)
        (arr[0, j], arr[row_size - 1, j]) = (arr[row_size - 1, j], arr[0, j]);
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] array = RandArr(row_num, column_num);

Print(array);
SwapRows(array);
Print(array);
