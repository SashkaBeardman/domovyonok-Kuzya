Console.WriteLine("\n==== Генерация последовательности Фибоначчи ====\n");
Console.Write("Введите количество чисел Фибоначчи для генерации: ");
int NumFib;
while (!int.TryParse(Console.ReadLine(), out NumFib))
{
    Console.Write("Ошибка! Введите корректное целое число: ");
}
int a = 0;
int b = 1;
int temp = a + b;
if (NumFib <= 0)
{
    Console.WriteLine("Значение должно быть больше 0.");
}
else
{
    Console.Write($"{a},{b}");
    for (int i = 0; i < NumFib; i++)
    {
        Console.Write($",{temp}");
        a = b;
        b = temp;
        temp = a + b;
    }
}