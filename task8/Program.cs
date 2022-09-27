//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

using static System.Console;
Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
int num2=2;
while(num2<num1)
{
Write($"{num2} ");
num2+=2;
}