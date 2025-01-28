
Console.Write("Введите номер дня недели (1-7):");
    int dayNumber = int.Parse(Console.ReadLine());

static string GetDayName(int dayNumber)
{
    switch (dayNumber)
    {
        case 1: return "Понедельник";
        case 2: return "Вторник";
        case 3: return "Среда";
        case 4: return "Четверг";
        case 5: return "Пятница";
        case 6: return "Субота";
        case 7: return "Воскресенье";
        default: return null;
    }
}

string dayName = GetDayName(dayNumber);

        if (dayName != null)
        {
            Console.WriteLine($"День недели: {dayName}");
        }
        else
        {
            Console.WriteLine("Номер введен не верно. Введите число от 1 до 7.");
        }
    


