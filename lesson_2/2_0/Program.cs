// 0. Напишите программу, которая принимает на вход трёхзначное число
//    и на выходе показывает последнюю цифру этого числа.

int showLastNum(int num) {
    Console.WriteLine(num);

    return num % 10;
}

int rand_num = new Random().Next(100, 1000);

int last_num = showLastNum(rand_num);
Console.WriteLine(last_num);
