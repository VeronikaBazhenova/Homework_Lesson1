﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

bool k = n == 0;
bool m = n == 1;

int count = 0;

if (k | m)
{
    Console.WriteLine("Таких чисел нет");
}
else
{
    if (n >= 0)
    {
        if (n % 2 == 0)
        {
            while (count < n)
            {
                count = count + 2;
                Console.Write(count + " ");
            }
        }
        else
        {
            while (count < (n - 1))
            {
                count = count + 2;
                Console.Write(count + " ");
            }
        }
    }
    else
if (n % 2 == 0)
    {
        while (count > n)
        {
            count = count - 2;
            Console.Write(count + " ");

        }
    }
    else
    {
        while (count > (n + 1))
        {
            count = count - 2;
            Console.Write(count + " ");
        }
    }
}
