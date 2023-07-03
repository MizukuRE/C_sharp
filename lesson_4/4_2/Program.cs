//  Напишите программу, которая принимает на вход
//  число N и выдаёт произведение чисел от 1 до N.

int MultipliNums(int num) {
    int result = 1;

    for (int i = 1; i <= num; i++)
        result *= i;

    return result;
}

int number = int.Parse(Console.ReadLine()!);
int result = MultipliNums(number);
Console.WriteLine(result);
