﻿// 1. Напишите программу замена элементов массива:
//    положительные элементы замените на соответствующие отрицательные, и наоборот.

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

void Invert(int[] arr) {
    for (int i = 0; i < arr.Length; i++)
        arr[i] *= -1;
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
Invert(result);
ShowArr(result);
