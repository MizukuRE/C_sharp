// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Polindrom(int num) {
    if (num > 99999 || num < 10000) {
        Console.WriteLine("Число не является пятизначным");
        return;
    }

    if (num / 10000 == num % 10 && (num / 1000) % 10 == (num % 100) / 10) {
        Console.WriteLine("Палиндром");
    } else {
        Console.WriteLine("Не палиндром");
    }
}

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);
Polindrom(number);
