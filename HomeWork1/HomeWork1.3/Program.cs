﻿// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

double number = -4; // Пример как для целых чисел, так и для вещественных

if (number % 2 == 0)
{
    Console.WriteLine($"{number} - четное число!");
}
else
{
    Console.WriteLine($"{number} - нечетное число!");
}