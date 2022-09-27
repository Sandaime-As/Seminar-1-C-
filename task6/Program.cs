//Напишите программу, которая на вход принимает число и выдаёт,
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

using static System.Console;
Clear();
Write("Введите число: ");
int num1 = Convert.ToInt32(ReadLine());
WriteLine(num1%2);
if (num1%2 == 0)
{
    Console.Write ("Yes");
}
else
{
   Console.Write ("No");
}