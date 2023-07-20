// 1. Задайте значение N. Напишите программу, которая выведет
//    все натуральные числа в промежутке от 1 до N при помощи рекурсии.

void RecPrint(int n) {
    if (n == 0)
        return;

    RecPrint(n - 1);
    Console.Write($"{n} ");
}

Console.WriteLine("Введте целое число: ");
int num = int.Parse(Console.ReadLine()!);

RecPrint(num);
