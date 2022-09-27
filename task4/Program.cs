//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

using static System.Console;
Clear();
WriteLine("Введите число: ");
int num1=Convert.ToInt32(ReadLine());
int num2=int.Parse(ReadLine()!);
int num3=int.Parse(ReadLine()!);

if (num1<num2)
if (num2<num3)
{
    WriteLine($"max = {num3}");
}

if (num2<num1)
if (num1<num3)
{
    WriteLine($"max = {num3}");
}

if (num2<num3)
if (num3<num1)
{
    WriteLine($"max = {num1}");
}

if (num3<num1)
if (num1<num2)
{
    WriteLine($"max = {num2}");
}

if (num3<num2)
if (num2<num1)
{
    WriteLine($"max = {num1}");
}