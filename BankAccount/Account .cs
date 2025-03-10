using System;
using System.Collections.Generic;

public class Account
{
    public string Name { get; private set; }
    private double balance;

    public double Balance => balance;

    public Account(string name, double initialBalance)
    {
        Name = name;
        balance = initialBalance >= 0 ? initialBalance : throw new ArgumentException("Баланс не может быть отрицательным");
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"На счет '{Name}' добавлено {amount} UAH.");
        }
        else
        {
            Console.WriteLine("Сумма депозита должна быть больше 0");
        }
    }

    public void Withdrawal(double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Со счета '{Name}' снято {amount} UAH.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств или некорректная сумма вывода");
        }
    }

    public void ShowBalance()
    {
        Console.WriteLine($"Баланс '{Name}': {balance} UAH.");
    }

    public void Transfer(Account targetAccount, double amount)
    {
        if (amount > 0 && balance >= amount)
        {
            balance -= amount;
            targetAccount.Deposit(amount);
            Console.WriteLine($"Переведено {amount} UAH. со счета '{Name}' на счет '{targetAccount.Name}'");
        }
        else
        {
            Console.WriteLine("Недостаточно средств или некорректная сумма перевода");
        }
    }
}