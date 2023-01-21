// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
using static System.Console;
Clear();

Write("Пять разных чисел через пробел ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);

int[] numbers = parameters.Select(s => int.Parse(s)).ToArray();


PrintArray(numbers);

int positiveSum = 0;

foreach(var a in numbers)
{
    if (a > 0) {
        positiveSum += 1;
    } 
}
WriteLine($"{positiveSum}");

void PrintArray(int[] inArray)
{
    Write("[");
        for (int i = 0; i < inArray.Length - 1; i++)
            {
                Write($"{inArray[i]},");
            }
    Write($"{inArray[inArray.Length - 1]}]");
}