//3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

void DayOfWeek(int num) {
    if (num > 7 || num == 0) {
        Console.WriteLine("Дня недели обозначаемого данной цифрой не существует");
        return;
    }

    if (num == 6 || num == 7)
        Console.WriteLine("Выходной");
    else
        Console.WriteLine("Будний");
}

Console.WriteLine("Введите цифру: ");
int number = int.Parse(Console.ReadLine()!);

DayOfWeek(number);
