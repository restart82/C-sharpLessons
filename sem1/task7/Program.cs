﻿// Задача №7.
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.Write("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine()!);

Console.Write("Вот его последняя цифра: " + (Number % 10));