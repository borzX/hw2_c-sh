﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine("Введите число: ");
int day_num = Convert.ToInt32(Console.ReadLine());


if (day_num>=1 & day_num<=5)
{
        Console.WriteLine("Рабочий день");
}
else if (day_num==6 | day_num==7)
{
        Console.WriteLine("Выходной день");
}
else Console.WriteLine("Вы ввели неверное число!");