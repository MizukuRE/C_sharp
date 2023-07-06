// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
// сумма отрицательных равна -20.

int[] RandArr(int size, int begin, int end) {
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(begin, end + 1);

    return result;  
}

void ShowArr(int[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        if (i + 1 == arr.Length) 
            Console.Write($"{arr[i]} "); 
        else
            Console.Write($"{arr[i]}, "); 
    }  
}

void SumPosNeg(int[] arr) {
    int pos_sum = 0;
    int neg_sum = 0;

    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] < 0)
            neg_sum += arr[i];
        else
            pos_sum += arr[i];
    }

    Console.WriteLine($"Сумма положительных чисел равна {pos_sum}");
    Console.WriteLine($"Сумма отрицательных чисел равна {neg_sum}");
}

Console.WriteLine("Введите размер нужного массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона: ");
int begin = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона: ");
int end = int.Parse(Console.ReadLine()!);

int[] result = RandArr(size, begin, end);
ShowArr(result);
Console.WriteLine();
SumPosNeg(result);
