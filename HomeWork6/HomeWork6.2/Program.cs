﻿// Напишите программу, которая найдет точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2, k2 задаются пользователем

System.Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double intersection = k1 * (b2 - b1) / (k1 - k2) + b1;

System.Console.WriteLine($"Точка пересечения двух прямых: {intersection}");
