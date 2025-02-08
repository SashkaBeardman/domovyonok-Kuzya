Console.WriteLine("\n==== Вычесление средней ЗП ====\n");
Console.Write("Введите кол-во сотрудников: ");
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