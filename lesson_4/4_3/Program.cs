// Напишите программу, которая выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.

int[] RandArr() {
    int[] result = new int[8];

    for (int i = 0; i < 8; i++)
        result[i] = new Random().Next(0, 2);

    return result;    
}

int[] result = RandArr();
for (int i = 0; i < 8; i++)
    Console.Write($"{result[i]} ");
