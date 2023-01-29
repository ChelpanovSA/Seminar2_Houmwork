// *Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным. 6 -> да; 7 -> да; 1 -> нет.

Console.Clear();
Console.WriteLine("Введите число cоответствующее дню недели: ");
int num =int.Parse(Console.ReadLine()!);

if (num > 0 && num <= 7)
{
   if (num > 5)
   {
      Console.WriteLine($"День недели {num} -> выходной");
   }
   else Console.WriteLine($"День недели {num} -> рабочий");
}
else Console.WriteLine("Введите число от 1 до 7");