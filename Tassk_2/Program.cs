﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int third = Convert.ToInt32(Console.ReadLine());

int max = first;
if (max < second)
{
    max = second;
    if (max < third)
    {
        max = third;
    }
}
else if (max < third)
{
    max = third;
}

Console.Write("max=");
Console.WriteLine(max);