﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine()), s = 0;
while (n > 0)
{
    s += n % 10;
    n = n/ 10;
}
Console.WriteLine(s);