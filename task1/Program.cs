﻿
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

    if (number1 == number2 * number2)
    {
    Console.Write("Да");
    }
    else 
    {
    Console.Write("Нет");
    }
