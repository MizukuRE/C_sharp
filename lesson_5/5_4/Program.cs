// 4. Найдите произведение пар чисел в одномерном массиве.
//    Парой считаем первый и последний элемент, второй и предпоследний
//    и т.д. Результат запишите в новом массиве.

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

int[] Composition(int[] arr) {
    int size;
    if (arr.Length % 2 == 0)
        size = arr.Length / 2;
    else
        size = arr.Length / 2 + 1;
    int[] result = new int[size];

    for (int i = 0; i < size; i++) {
        if (i == arr.Length - 1 - i) {
            result[i] = arr[i];
            break;
        }
        result[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    
    return result;
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
int[] comp = Composition(result);
ShowArr(comp);
