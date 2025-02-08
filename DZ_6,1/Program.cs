using static System.Runtime.InteropServices.JavaScript.JSType;
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Домашка =)\n");
Console.ResetColor();
Console.WriteLine("\n==== Вычесление средней ЗП ====\n");
Console.ResetColor(); Console.Write("Введите кол-во сотрудников: ");
int men;
while (!int.TryParse(Console.ReadLine(), out men))
{
    Console.Write("Ошибка! Введите корректное целое число: ");
}
{
    double[] salary = new double[men];
    for (int с = 0; с < men; с++)
    {
        Console.Write("Введите ЗП сотрудника №" + (с + 1) + ": ");
        salary[с] = int.Parse(Console.ReadLine());
    }
    double SumSalary = salary.Sum();
    double result = SumSalary / men;
    Console.WriteLine("Средняя зп = " + result);
}

Console.WriteLine("\n==== График звездочками ====\n");
Console.Write("Введите кол-во строк: ");
int Star;
while (!int.TryParse(Console.ReadLine(), out Star))
{
    Console.Write("Ошибка! Введите корректное целое число: ");
}
{
    Console.WriteLine("График:");
    for (int d = 1; d <= Star; d++)
        Console.WriteLine(new string('*', d));
}


Console.WriteLine("\n==== Проверка пароля ====\n");
Console.Write("Введите пароль: ");
string pass = Console.ReadLine();
bool VerifiPass;
if (pass.Length >= 8)
{
    VerifiPass = pass.Any(char.IsLetter);
    Console.Write(VerifiPass ? "" : "Пароль не содержит букв / ");
    VerifiPass = pass.Any(char.IsDigit);
    Console.Write(VerifiPass ? "" : "Пароль не содержит цифр / ");
    VerifiPass = pass.Any(char.IsPunctuation);
    Console.Write(VerifiPass ? "" : "Пароль не содержит знаков препинания / ");
    VerifiPass = pass.Any(char.IsSymbol);
    Console.WriteLine(VerifiPass ? "" : "Пароль не содержит символов");
    bool result = pass.Any(c => char.IsLetter(c)) && pass.Any(c => char.IsDigit(c)) && pass.Any(c => char.IsPunctuation(c)) && pass.Any(c => char.IsSymbol(c));
    Console.WriteLine(result ? "-----------------\n| Пароль принят |\n-----------------" : "--------------------\n| Пароль не принят |\n--------------------");
}
else
{
    Console.WriteLine("Пароль содержит меньше 8 символов");
}

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

Console.WriteLine("\n\n==== Таблица умножения ====\n");
Console.Write("Введите число для вывода таблици умножения: ");

int multiplication = int.Parse(Console.ReadLine());
for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"{multiplication}*{i}=" + i * multiplication);
}

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
