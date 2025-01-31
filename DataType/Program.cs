Console.Write("Введите число:");
try
{
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Вы ввели число: {a}");
}
catch
{
    Console.Write("Значение не является числом");
}