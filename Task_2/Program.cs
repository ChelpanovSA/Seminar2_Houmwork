// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// (Цифры считать справа налево) 645 -> 6; 78 -> третьей цифры нет; 32679 -> 6.

Console.Clear();
Console.WriteLine("Введите любое натуральное число число: ");
int num =int.Parse(Console.ReadLine()!);

int numA = num / 100;

if (numA <= 1) Console.WriteLine($"третьей цифры числа {num} нет");
else numA =  numA % 10;


Console.WriteLine($"третья цифра, заданного числа -> {numA}");