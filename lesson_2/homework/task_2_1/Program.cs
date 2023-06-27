//2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNum(int num) {
    if (num / 100 == 0) {
        Console.WriteLine("третьей цифры нет");
        return;
    }

    int result = num;
    while (result / 1000 != 0) {
        result = result / 10;
    }
    result = result % 10;

    Console.WriteLine(result);
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

ThirdNum(number);
