// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.WriteLine("Введите первое число: ");

int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");

int y = Convert.ToInt32(Console.ReadLine());

if (x == y*y || y == x*x)
{
Console.WriteLine($" Число является квадратом ");

}
else
{
Console.WriteLine($" Квадрат отсутсвует ");
}