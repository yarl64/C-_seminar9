﻿// Напишите программу, которая выводит случайное трезначное число 
// и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int x = new Random().Next(100, 1000);
Console.WriteLine($"Было сгенерировано число {x}");

int x1 = x / 100;
int x2 = x %100;
int x3 = x2 %10;

Console.Write(x1);
Console.Write(x3);