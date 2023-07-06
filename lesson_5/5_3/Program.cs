// 3. Задайте одномерный массив из 123 случайных чисел.
//    Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

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

int Filter(int[] arr) {
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] >= 10 && arr[i] <= 99)
            count++;
    
    return count;
}

Console.WriteLine("Введите размер нужного массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона: ");
int begin = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона: ");
int end = int.Parse(Console.ReadLine()!);

int[] result = RandArr(size, begin, end);
ShowArr(result);
Console.WriteLine("\n" + Filter(result));
