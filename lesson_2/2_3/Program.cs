// 4. Напишите программу, которая принимает на вход число и проверяет,
//    кратно ли оно одновременно 7 и 23.

// 14 -> нет
// 46 -> нет
// 161 -> да

static void multiple(int num) {
    if (num % 7 == 0 && num % 23 == 0)
        Console.WriteLine("да");
    else
        Console.WriteLine("нет");
}

int num = int.Parse(Console.ReadLine()!);

multiple(num);
