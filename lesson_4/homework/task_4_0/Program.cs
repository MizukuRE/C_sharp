// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int MyPow(int a, int b) {
    int result = 1;

    for (int i = 0; i < b; i++) {
        result *= a;
    }

    return result;
}

Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

int result = MyPow(a, b);
Console.WriteLine($"a в степени b равно - {result}");
