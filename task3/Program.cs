//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Clear();
Console.Write("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 1)
Console.WriteLine("Понедельник");
if (num1 == 2)
Console.WriteLine("Вторник");
if (num1 == 3)
Console.WriteLine("Среда");
if (num1 == 4)
Console.WriteLine("Четверг");
if (num1 == 5)
Console.WriteLine("Пятница");
if (num1 == 6)
Console.WriteLine("Суббота");
if (num1 == 7)
Console.WriteLine("Воскресенье");
if (num1 > 7 || num1 < 1)
Console.WriteLine("Неверный день недели");