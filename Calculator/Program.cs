using System;

double a, b;
char CalcAction;
Console.Write("Введите a: ");
    a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b: ");
    b = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите действие (+, -, *, /): ");
    CalcAction = Convert.ToChar(Console.ReadLine());

    Console.WriteLine("\n==== Решение примера ====");
    switch (CalcAction)
    {
        case '+':
            Console.WriteLine($"{a}+{b} = {a + b}");
            break;
        case '-':
            Console.WriteLine($"{a}-{b} = {a - b}");
        break;
        case '*':
            Console.WriteLine($"{a}*{b} = {a * b}");
        break;
        case '/':
        if (b==0)
            Console.WriteLine("Ошибка: Деление на 0 невозможно.");
        else
        Console.WriteLine($"{a}/{b} = {a / b}");
        break;
        default:
            Console.WriteLine("Ошибка, введен некорректный знак математической операции");
            break;
    }