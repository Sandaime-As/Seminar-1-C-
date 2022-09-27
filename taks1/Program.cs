//Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.
//a = 25; b = 5 -> да
//a = 2 b = 10 -> нет
//a = 9; b = -3 -> да
//a = -3 b = 9 -> нет

Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 * num2 == num1)
{
    Console.Write ("Первое число является квадратом второго");
}
else
{
    Console.Write ("Первое число не является квадратом второго");
}