// 2. Задайте массив. Напишите программу, которая определяет,
//    присутствует ли заданное число в массиве.

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

string ToBeOrNot(int[] arr, int a) {
    for (int i = 0; i < arr.Length; i++) {
        if (arr[i] == a)
            return "Да";
    }
    return "Нет";
}

Console.WriteLine("Введите размер нужного массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите начало диапазона: ");
int begin = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец диапазона: ");
int end = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine()!);

int[] result = RandArr(size, begin, end);
ShowArr(result);
Console.WriteLine("\n" + ToBeOrNot(result, number));
