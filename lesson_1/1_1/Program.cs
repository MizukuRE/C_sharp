// 1. Напишите программу, которая на вход принимает два числа и проверяет,
//    является ли первое число квадратом второго.

Console.WriteLine("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);

if (num_1 / num_2 == num_2) {
    Console.WriteLine("+");
} else {
    Console.WriteLine("-");
}
