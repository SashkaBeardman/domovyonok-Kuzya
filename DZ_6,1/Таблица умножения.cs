Console.WriteLine("\n\n==== Таблица умножения ====\n");
Console.Write("Введите число для вывода таблици умножения: ");

int multiplication = int.Parse(Console.ReadLine());
for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{multiplication}*{i}=" + i * multiplication);
}