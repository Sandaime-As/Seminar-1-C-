﻿//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите число: ");
int num1=Convert.ToInt32(Console.ReadLine());
int num2=int.Parse(Console.ReadLine()!);

if (num1<num2)
{
    Console.WriteLine($"max = {num2}");
}
if (num1>num2)
{
    Console.WriteLine($"max = {num1}");
}
else
{
   Console.WriteLine($"min = {num1}");
}