using System;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        //=================================== Генерация массива
        int[] RandomNum = new int[10];
        Random NumGegeration = new Random();
        int RandomNumLeng = 10;
        for (int i = 0; i < RandomNumLeng; i++)
        {
            int NewNum = NumGegeration.Next(-10, 11);
            RandomNum[i] = NewNum;
        }
        Console.Write($"Рандом массив:");
        for (int i = 0; i < RandomNumLeng; i++)
        {
            Console.Write($"{RandomNum[i]},");
        }
        Console.WriteLine($"\nЭлементы с парным индексом: {RandomNum[2]},{RandomNum[4]},{RandomNum[6]},{RandomNum[8]}");
        //=================================== Сумма элементов массива
        int sum = RandomNum.Sum();
        Console.WriteLine("Сумма чисел: " + sum);
        //=================================== Двухмерный массив 9*9(таблица умножения)
        Console.WriteLine("\nДвухмерный массив 9*9(таблица умножения)");
        int[,] MyltiLinetable = new int[9, 9];
        for (int i = 0; i < MyltiLinetable.GetLength(0); i++)
        {
            for (int j = 0; j < MyltiLinetable.GetLength(0); j++)
            {
                MyltiLinetable[i, j] = (i + 1) * (j + 1);
            }
        };
        for (int i = 0; i < MyltiLinetable.GetLength(0); i++)
        {
            for (int j = 0; j < MyltiLinetable.GetLength(1); j++)
            {
                Console.Write(MyltiLinetable[i, j] + " ");
            }
            Console.WriteLine();
        }
        //=================================== Двухмерный массив 5*5 c условиями вывода
        Console.WriteLine("\nДвухмерный массив 5*5 c условиями вывода");
        int max = int.MinValue;
        int min = int.MaxValue; 

        int[,] MyltiLineFilter = new int[5, 5];
        Random NumGegerationArray = new Random();
        for (int k = 0; k < MyltiLineFilter.GetLength(0); k++)
        {
            for (int l = 0; l < MyltiLineFilter.GetLength(0); l++)
            {
                int NewNumArray = NumGegerationArray.Next(-10, 101);
                MyltiLineFilter[k, l] = NewNumArray;
                Console.Write(MyltiLineFilter[k, l] + " ");
            }
            Console.WriteLine();
        };
        //максимальное/минимальное значение
        foreach (int num in MyltiLineFilter)
        {
            if (num > max)
                max = num;
            if (num < min)
                min = num;
        }
        Console.WriteLine($"Максимальное значение: {max}");
        Console.WriteLine($"Минимальное значение: {min}");
        for (int m = 0; m < MyltiLineFilter.GetLength(0); m++)
        {
            for (int n = 0; n < MyltiLineFilter.GetLength(0); n++)
            {
                if( MyltiLineFilter[m, n] == max) {Console.WriteLine($"Кординаты максимального значения: [{m}][{n}]");break; }
                if( MyltiLineFilter[m, n] == min) {Console.WriteLine($"Кординаты минимального значения: [{m}][{n}]");break; }              
            }
        };
        //=================================== Enum и предстоящий день недели
        Console.Write("\nВведите кол-во дней: ");
        if (int.TryParse(Console.ReadLine(), out int days))
        {
            Week startDay = Week.Понедельник;
            Week resultDay = (Week)((int)(startDay + days) % 7);
            Console.WriteLine($"Через {days} дней будет: {resultDay}");
        }
        else
        {
            Console.WriteLine("Пожалуйста, введите корректное число.");
        }
    }
}
    enum Week{
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }

