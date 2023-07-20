// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int SumNum(int num) {
    if (num / 10 == 0)
        return num;

    return num % 10 + SumNum(num / 10 );
}

Console.WriteLine("Введте целое число: ");
int num = int.Parse(Console.ReadLine()!);
int result = SumNum(num);
Console.WriteLine(result);
