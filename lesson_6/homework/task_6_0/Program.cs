/* 
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int GreaterThanZeroCount(int[] arr) {
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0)
            count++;

    return count;
}

Console.WriteLine("Введите количество чисел");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите числа");
int[] array = new int[size];
for (int i = 0; i < array.Length; i++)
    array[i] = int.Parse(Console.ReadLine()!);

int result = GreaterThanZeroCount(array);
Console.WriteLine("\n" + result);