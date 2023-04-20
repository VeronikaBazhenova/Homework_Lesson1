// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число");
int first = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int second = Convert.ToInt32(Console.ReadLine());

int max = first, min = second;

if (max>min)
{
    Console.Write("max=");
    Console.WriteLine(max);
    Console.Write("min=");
    Console.WriteLine(min);
}
else 
{
    Console.Write("max=");
    Console.WriteLine(min);
    Console.Write("min=");
    Console.WriteLine(max);
}
