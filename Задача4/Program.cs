﻿//  Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number % 10);