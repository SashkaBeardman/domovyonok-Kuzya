Console.WriteLine("\n==== Проверка на простоту ====\n");
Console.Write("Введите число для проверки: ");
bool RemNun = true;
int Num;
while (!int.TryParse(Console.ReadLine(), out Num))
{
    Console.Write("Ошибка! Введите корректное целое число: ");
}
for (int i = 2; i < Num; i++)
{
    Console.WriteLine($"{Num} % {i}={Num % i}");
    if (Num % i == 0)
    {
        RemNun = false;
        break;
    }
}
if (RemNun)
{
    Console.WriteLine($"Число {Num} - простое");
}
else
{
    Console.WriteLine($"Число {Num} - простым не является");
}
