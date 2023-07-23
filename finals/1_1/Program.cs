// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumNums(int m, int n) {
    if (n < m)
        return 0;

    return n + SumNums(m, n - 1);
}

Console.WriteLine("Введте целое число M: ");
int num_m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введте целое число N: ");
int num_n = int.Parse(Console.ReadLine()!);

int result = SumNums(num_m, num_n);
Console.WriteLine(result);
