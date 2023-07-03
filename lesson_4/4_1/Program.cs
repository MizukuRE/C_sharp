//  Напишите программу, которая принимает
//  на вход число и выдаёт количество цифр в числе.

int AmountNums(int num) {
    int result = 0;
    
    for (int i = 1; num > 0; i++) {
        num /= 10;
        result = i;
    }

    return result;
}

int number = int.Parse(Console.ReadLine()!);
int result = AmountNums(number);
Console.WriteLine(result);
