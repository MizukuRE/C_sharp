/* 
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

void Intersection(double b1, double k1, double b2, double k2) {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine($"({Math.Round(x, 2)}; {Math.Round(y, 2)})");
}

Console.WriteLine("Введите коэффициент b1");
double b1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент k1");
double k1 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент b2");
double b2 = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите коэффициент k2");
double k2 = double.Parse(Console.ReadLine()!);

Intersection(b1, k1, b2, k2);