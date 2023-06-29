// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

void PowTable(int n) {
    if (n == 0) {
        Console.WriteLine("1");
        return;
    }

    int count = 1;

    while (count <= n) {
        Console.Write($"{Math.Pow(count, 2)}, ");

        count++;
    }
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

PowTable(num);
