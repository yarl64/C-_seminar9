﻿// Напишите программу, которая будет принимать на вход два числа и
// выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите целое число");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число");
int y = Convert.ToInt32(Console.ReadLine());
int remains = y % x;

if (remains == 0)
{
    Console.WriteLine("Кратно");
}

else
{
    Console.WriteLine("Не кратно, остаток " + remains);
}