// Напишите программу, которая принимает
// на вход число (А) и выдаёт сумму чисел от 1 до А.

int SumNums(int num) {
    int result = 0;

    for (int i = 1; i <= num; i++)
        result += i;

    return result;
}

int number = int.Parse(Console.ReadLine()!);
int result = SumNums(number);
Console.WriteLine(result);
