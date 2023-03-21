// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int n = 8;
//         PrintNumbers(n);
//     }

//     static void PrintNumbers(int n)
//     {
//         if (n > 0)
//         {
//             Console.Write(n + ", ");
//             PrintNumbers(n - 1);
//         }
//         else
//         {
//             Console.WriteLine();
//         }
//     }
// }




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int M = 1, N = 15;
//         int sum = SumNatural(M, N);
//         Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");

//         M = 4; N = 8;
//         sum = SumNatural(M, N);
//         Console.WriteLine($"Сумма натуральных чисел от {M} до {N} равна {sum}");

//         Console.ReadKey();
//     }

//     static int SumNatural(int m, int n)
//     {
//         if (m == n)
//         {
//             return m;
//         }
//         else 
//         {
//             return m + SumNatural(m + 1, n);
//         }
//     }
// }




// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 2;
        int n = 3;
        int result = AckermannFunction(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);

        m = 3;
        n = 2;
        result = AckermannFunction(m, n);
        Console.WriteLine("A({0}, {1}) = {2}", m, n, result);
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1; 
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1); 
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1)); 
        }
    }
}