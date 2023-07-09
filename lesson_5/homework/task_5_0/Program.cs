// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] RandArr(int size) {
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
        result[i] = new Random().Next(100, 1000);

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

int EvenAmount(int[] arr) {
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            count++;

    return count;
}

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] result = RandArr(size);
ShowArr(result);
Console.WriteLine("\n" + EvenAmount(result));
