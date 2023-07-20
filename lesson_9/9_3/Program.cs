// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.

int MyPow(int a, int b) {
    if (b == 0)
        return 1;

    return a * MyPow(a, b - 1);
}

Console.WriteLine("Введте целое число A: ");
int num_a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введте целое число B: ");
int num_b = int.Parse(Console.ReadLine()!);

int result = MyPow(num_a, num_b);
Console.WriteLine(result);
