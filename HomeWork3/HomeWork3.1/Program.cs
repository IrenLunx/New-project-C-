﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int number = 57865;
if (number % 10 == number / 10000 && number / 10 % 10 == number / 1000 % 10)
    System.Console.WriteLine($"Число {number} является палиндромом!");
else
    System.Console.WriteLine($"Число {number} не является палиндромом!");