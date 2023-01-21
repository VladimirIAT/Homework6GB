// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
using static System.Console;
Clear();

Write("Введите число b1: ");
int b1 = int.Parse(ReadLine()!);
Write("Введите число k1: ");
int k1 = int.Parse(ReadLine()!);
Write("Введите число b2: ");
int b2 = int.Parse(ReadLine()!);
Write("Введите число k2: ");
int k2 = int.Parse(ReadLine()!);

WriteLine($"({Count(b1, k2, b2, k2)}; {Count(b1, k2, b2, k2) * k1 + b1})");

double Count(int a, int b, int c, int d)
{
    double x = ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
    return x;
}