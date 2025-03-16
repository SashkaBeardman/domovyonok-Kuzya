using System;
using System.Collections.Generic;

public class Account
{
    public string Name { get; private set; }

    private double balance;
    public double Balance
    {
        get => balance;
        private set
        {
            if (value < 0)
            {
                throw new InvalidOperationException("Баланс не может быть отрицательным.");
            }
            balance = value;
        }
    }

    public Account(string name, double initialBalance)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name), "Имя не может быть null.");
        Balance = initialBalance >= 0 ? initialBalance : throw new ArgumentException("Баланс не может быть отрицательным.");
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"На счет '{Name}' добавлено {amount} UAH.");
        }
        else
        {
            Console.WriteLine("Сумма депозита должна быть больше 0.");
        }
    }

    public void Withdrawal(double amount)
    {
        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"Со счета '{Name}' снято {amount} UAH.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств или некорректная сумма вывода.");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Баланс '{Name}': {Balance} UAH.");
    }

    public void Transfer(Account targetAccount, double amount)
    {
        if (targetAccount == null)
        {
            Console.WriteLine("Ошибка: целевой аккаунт не может быть null.");
            return;
        }

        if (amount > 0 && Balance >= amount)
        {
            Balance -= amount;
            targetAccount.Balance += amount; // Прямое изменение баланса через сеттер
            Console.WriteLine($"Переведено {amount} UAH со счета '{Name}' на счет '{targetAccount.Name}'.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств или некорректная сумма перевода.");
        }
    }
}