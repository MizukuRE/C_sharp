//2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int num_1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int num_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите третье число: ");
int num_3 = int.Parse(Console.ReadLine()!);

if (num_1 > num_2) {
    if (num_1 > num_3) {
        Console.WriteLine(num_1 + " максимальное");
    } else {
        Console.WriteLine(num_3 + " максимальное");
    }
} else {
    if (num_2 > num_3) {
        Console.WriteLine(num_2 + " максимальное");
    } else {
        Console.WriteLine(num_3 + " максимальное");
    }
}
