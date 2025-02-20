using System;
using System.Text;
        StringBuilder ReportBuilder = new StringBuilder();
        StringBuilder EventsBuilder = new StringBuilder();
        while (true)
        {
            Console.Write("Введдите дату(число): ");
        if (int.TryParse(Console.ReadLine(), out int TimeInputDay) && TimeInputDay >= 1 && TimeInputDay <= 31) ;
        else
        {
            Console.WriteLine("Некорректный ввод! Нажмите Enter и попробуйте снова.");
            Console.ReadLine();
            Console.Clear();
            continue;
        }
            Console.Write("Введдите дату(месяц): ");
        if (int.TryParse(Console.ReadLine(), out int TimeInputMonth) && TimeInputMonth >= 1 && TimeInputMonth <= 12) ;
        else
        {
            Console.WriteLine("Некорректный ввод! Нажмите Enter и попробуйте снова.");
            Console.ReadLine();
            Console.Clear();
            continue;
        }
            Console.Write("Введдите событие: ");
            string UserInput = Console.ReadLine();

        // Додавання події до списку
        if (!string.IsNullOrWhiteSpace(UserInput))
        {
            EventsBuilder.AppendLine($"Дата: {TimeInputDay}/{TimeInputMonth}");
            EventsBuilder.AppendLine($"- {UserInput}");
        }
            Console.Write("Продолжить?(Enter - что бы продолжить/'Стоп' - что бы завершить ввод): ");
            string Continue =Console.ReadLine();
    
        if (Continue?.ToLower() == "стоп")//проверка на окончание ввода событий
            Console.Clear();
            break;
            }

        if (EventsBuilder.Length > 0)//проверяем ввод и записываем
        {
			ReportBuilder.AppendLine("Список событий:");
            ReportBuilder.Append(EventsBuilder);
        }
        else
        {
            ReportBuilder.AppendLine("Событие не введено.");
        }

        // Виведення сформованого звіту
        Console.WriteLine("\n=== Текстовый отчет ===");
        Console.WriteLine(ReportBuilder.ToString());

