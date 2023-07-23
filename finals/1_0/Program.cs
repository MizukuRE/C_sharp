// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

void EvenNums(int m, int n) {
    if (n % 2 != 0)
        n--;

    if (n < m)
        return;
    
    EvenNums(m, n - 2);
    Console.Write($"{n} ");
}

Console.WriteLine("Введте целое число M: ");
int num_m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введте целое число N: ");
int num_n = int.Parse(Console.ReadLine()!);

EvenNums(num_m, num_n);
