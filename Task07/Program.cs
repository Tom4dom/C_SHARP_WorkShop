﻿// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8


Console.WriteLine("Dear user input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int lastdigit = number%10;
Console.WriteLine(lastdigit);