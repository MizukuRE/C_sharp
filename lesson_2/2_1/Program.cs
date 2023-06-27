// 1. Напишите программу, которая выводит случайное число
//    из отрезка [10, 99] и показывает наибольшую цифру числа.

int showGreaterNum(int num) {
    Console.WriteLine(num);
    int res;
    if (num % 10 > num / 10)
        res = num % 10;
    else
        res = num / 10;
    return res;
}

int rand_num = new Random().Next(10, 100);

int greater_num = showGreaterNum(rand_num);
Console.WriteLine(greater_num);
