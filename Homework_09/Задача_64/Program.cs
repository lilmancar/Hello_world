﻿Console.WriteLine("Приветствую! ");
Console.WriteLine("Это программа выводит все натуральные числа в промежутке от M до N.");
Console.Write("Введите N: ");
int N = Convert.ToInt16(Console.ReadLine());
Console.Write("Введите M: ");
int M = Convert.ToInt16(Console.ReadLine());
Console.WriteLine($"N={N}, M={M}");
if (M>N)
for (int i = N; i <= M; i++)
    Console.Write($" {i}");
else
    for (int i = M; i <= N; i++)
        Console.Write($" {i}");