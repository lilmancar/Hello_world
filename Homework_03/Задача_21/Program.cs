﻿Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа принимает на вход координаты двух точек ");
Console.WriteLine("И находит расстояние между ними в 3D пространстве. ");
double x, y, z, x1, y1, z1, len;
Console.WriteLine("Введите x точки А : ");
x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y точки А : ");
y = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z точки А : ");
z = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x точки B : ");
x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y точки B : ");
y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z точки B : ");
z1 = Convert.ToDouble(Console.ReadLine());
len = Math.Sqrt((x - x1) * (x - x1) + (y - y1) * (y - y1)+ (z - z1)*(z - z1));
Console.Write("Расстояние между точками A и B : ");
Console.WriteLine(len - len % 0.01);
