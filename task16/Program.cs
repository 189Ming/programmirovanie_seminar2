﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());

bool result = MultipleTwoDigits(number, 5, 10);
Console.WriteLine(result ? "да" : "нет");

bool MultipleTwoDigits(int num, int num1, int num2)
{
    return num % num1 == 0 && num % num2 == 0;
}