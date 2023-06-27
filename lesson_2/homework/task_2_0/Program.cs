//1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int MiddleNum(int num) {
    int result = (num / 10) % 10;

    return result;
}

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 1000 || number < 100) {
    Console.WriteLine("Введённое чило не является трёхзначным!");

    return;
}

int mid_num = MiddleNum(number);
Console.WriteLine(mid_num);
