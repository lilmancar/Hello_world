﻿Console.WriteLine("Приветствую! ");
Console.WriteLine("Эта программа принимает на вход координаты двух точек ");
Console.WriteLine("И находит расстояние между ними в 3D пространстве. ");
double b1, k1, b2, k2, x;
Console.WriteLine("Введите x точки b1 : ");
b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите y точки k1 : ");
k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите z точки b2 : ");
b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите x точки k2 : ");
k2 = Convert.ToDouble(Console.ReadLine());
x = (b2-b1)/(k1-k2);
y = k1(b2-b1)/(k1-k2)+b1;
Console.WriteLine(x, y);