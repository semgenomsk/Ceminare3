﻿// Задача 22: Напишите программу, которая принимает на вход 
// число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 0;

if (N > 0)
{
    while (i <= N)
    {
        Console.Write(i * i + " ");
        i++;
    }
}
    else
    {
        Console.WriteLine("Число N должно быть больше 0!");
    }