//1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);

if (num_1 > num_2) {
    Console.WriteLine(num_1 + " больше чем " + num_2);
} else {
    Console.WriteLine(num_2 + " больше чем " + num_1);
}
