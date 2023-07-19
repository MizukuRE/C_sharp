// 3. Составить частотный словарь элементов двумерного массива.
//    Частотный словарь содержит информацию о том, сколько раз 
//    встречается элемент входных данных. Значения элементов массива 0..9

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

void FrequencyDict(int[,] arr) {
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < 10; i++)
    {
        int count = 0;

        foreach (int item in arr)
            if (item == i)
                count++;

        Console.WriteLine($"{i}: {count}");
    }
    Console.WriteLine();
}

Console.Write("Enter the number of rows: ");
int row_num = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns: ");
int column_num = int.Parse(Console.ReadLine()!);

int[,] array = RandArr(row_num, column_num);
Print(array);

FrequencyDict(array);
