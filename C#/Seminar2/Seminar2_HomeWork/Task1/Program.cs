﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (1000<=a) 
{
    Console.WriteLine("Трёхзначное - это число из ТРЁХ символов ");
}
else 
{
    int b = (a/10);
    int c = (b%10);
Console.WriteLine($"Вторая цифра числа  {a} -    {c}");
}

