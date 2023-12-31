﻿/* 
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int SumOfNum(int num) {
    int result = 0;
    
    for (; num > 0; num /= 10)
        result += num % 10;

    return result;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
int result = SumOfNum(number);
Console.WriteLine(result);
