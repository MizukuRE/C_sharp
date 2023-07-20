// 2. Задайте значения M и N. Напишите программу, которая 
//    рекурсивно выведет все натуральные числа в промежутке от M до N.

void RecPrint(int m, int n) {
    if (n == m - 1)
        return;

    RecPrint(m, n - 1);
    Console.Write($"{n} ");
}

Console.WriteLine("Введте целое число M: ");
int num_m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введте целое число N: ");
int num_n = int.Parse(Console.ReadLine()!);

RecPrint(num_m, num_n);
