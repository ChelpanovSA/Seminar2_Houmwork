// *Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5; 782 -> 8; 918 -> 1

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num =int.Parse(Console.ReadLine()!);

int numA = num / 10;
int numB = numA % 10;
Console.WriteLine($"Вторая цифра числа {num} -> {numB}");

