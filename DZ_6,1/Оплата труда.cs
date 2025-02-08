Console.WriteLine("\n\n==== Калькулятор оплаты труда за час ====\n");
Console.Write("Введите количество отработаных часов: ");
int TimeWork;
while (!int.TryParse(Console.ReadLine(), out TimeWork))
{
    Console.Write("Ошибка! Введите корректное число часов: ");
}
Console.Write("Введите сумму оплаты за час: ");
int Price;
while (!int.TryParse(Console.ReadLine(), out Price))
{
    Console.Write("Ошибка! Введите корректную сумму оплаты: ");
}
Console.Write($"За смену из {TimeWork} часов, вы получите " + TimeWork * Price);
