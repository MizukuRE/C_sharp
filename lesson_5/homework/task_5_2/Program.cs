// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.


double[] RandArr(int size, int begin, int end) {
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
        result[i] = new Random().NextDouble() * (end - begin) + begin;

    return result;  
}

void ShowArr(double[] arr) {
    for (int i = 0; i < arr.Length; i++) {
        if (i + 1 == arr.Length) 
            Console.Write($"{arr[i]} "); 
        else
            Console.Write($"{arr[i]}, "); 
    }  
}

double MinMaxDiff(double[] arr) {
    double min = arr[0];
    double max = arr[0];

    for (int i = 0; i < arr.Length; i++) {
        if (max < arr[i])
            max = arr[i];
        if (min > arr[i])
            min = arr[i];
    }

    return max - min;
}

Console.WriteLine("Введите размер нужного массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона: ");
int begin = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона: ");
int end = int.Parse(Console.ReadLine()!);

double[] result = RandArr(size, begin, end);
ShowArr(result);
Console.WriteLine("\n" + MinMaxDiff(result));
