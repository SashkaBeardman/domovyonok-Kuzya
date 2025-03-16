class Program
{
    static void Main()
    {
        List<Account> accounts = new List<Account>
        {
            new Account("Alex", 0),
            new Account("AlexSwitz", 0)
        };

        while (true)
        {
            Console.WriteLine("\nМеню:");
            Console.WriteLine("1. Выбрать счет");
            Console.WriteLine("2. Выйти");
            Console.Write("Выберите пункт: ");
            string choice = Console.ReadLine();
            Console.Clear();

            if (choice == "1")
            {
                Console.WriteLine("Доступные счета:");
                for (int i = 0; i < accounts.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {accounts[i].Name}");
                }
                Console.Write("Выберите номер счета: ");

                if (int.TryParse(Console.ReadLine(), out int accountIndex) && accountIndex > 0 && accountIndex <= accounts.Count)
                {
                    Account selectedAccount = accounts[accountIndex - 1];

                    while (true)
                    {
                        Console.WriteLine($"\nМеню счета:{selectedAccount.Name}");
                        Console.WriteLine("1. Показать баланс");
                        Console.WriteLine("2. Пополнить счет");
                        Console.WriteLine("3. Снять деньги");
                        Console.WriteLine("4. Перевести деньги");
                        Console.WriteLine("5. Назад");
                        Console.Write("Выберите пункт: ");

                        string accountChoice = Console.ReadLine();
                        Console.Clear();
                        switch (accountChoice)
                        {
                            case "1":
                                selectedAccount.ShowBalance();
                                break;
                            case "2":
                                Console.Write("Введите сумму для пополнения: ");
                                if (double.TryParse(Console.ReadLine(), out double depositAmount))
                                {
                                    selectedAccount.Deposit(depositAmount);
                                    selectedAccount.ShowBalance();
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод!");
                                }
                                break;
                            case "3":
                                Console.Write("Введите сумму для снятия: ");
                                if (double.TryParse(Console.ReadLine(), out double withdrawAmount))
                                {
                                    selectedAccount.Withdrawal(withdrawAmount);
                                    selectedAccount.ShowBalance();
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный ввод!");
                                }
                                break;
                            case "4":
                                Console.WriteLine($"Текущий счет: {selectedAccount.Name}");
                                Console.WriteLine("Введите номер счета для перевода (получателя):");

                                for (int i = 0; i < accounts.Count; i++)
                                {
                                    if (i != accountIndex - 1)
                                        Console.WriteLine($"{i + 1}. {accounts[i].Name}");
                                }

                                if (int.TryParse(Console.ReadLine(), out int targetIndex) && targetIndex > 0 && targetIndex <= accounts.Count && targetIndex != accountIndex)
                                {
                                    Console.Write("Введите сумму для перевода: ");
                                    if (double.TryParse(Console.ReadLine(), out double transferAmount))
                                    {
                                        selectedAccount.Transfer(accounts[targetIndex - 1], transferAmount);
                                        selectedAccount.ShowBalance();
                                    }
                                    else
                                    {
                                        Console.WriteLine("Некорректный ввод!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный выбор счета!");
                                }
                                break;
                            case "5":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("Некорректный выбор, попробуйте снова.");
                                break;
                        }
                        if (accountChoice == "5") break;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный выбор счета!");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("Выход из программы.");
                return;
            }
            else
            {
                Console.WriteLine("Некорректный выбор, попробуйте снова.");
            }
        }
    }
}