
Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int num =int.Parse(Console.ReadLine()!);

if (num % 100 != 0 )
{
    Console.WriteLine($"Трехзначное число");
}
else
{
    Console.WriteLine("Это НЕ ТРЁХЗНАЧНОЕ число");
}