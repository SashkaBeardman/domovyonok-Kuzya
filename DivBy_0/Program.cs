using System;

int a, b;
Console.Write("Введите a: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b: ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n==== Решение примера ====");
try
{
    Console.WriteLine($"{a}/{b} = {a / b}");
}
catch
{
    Console.WriteLine("Ошибка: Деление на 0 невозможно.");
}