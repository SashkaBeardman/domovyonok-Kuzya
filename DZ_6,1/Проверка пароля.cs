using System.ComponentModel.Design;

Console.WriteLine("\n==== Проверка пароля ====\n");
Console.Write("Введите пароль: ");
string pass = Console.ReadLine();
bool VerifiPass;
if (pass.Length >= 8)
{
    VerifiPass = pass.Any(char.IsLetter);
    int passLetter = VerifiPass ? 1 : 0;
    Console.Write(VerifiPass ? "" : "Пароль не содержит букв / ");
    VerifiPass = pass.Any(char.IsDigit);
    int passDigit = VerifiPass ? 1 : 0;
    Console.Write(VerifiPass ? "" : "Пароль не содержит цифр / ");
    VerifiPass = pass.Any(char.IsPunctuation);
    int passPunctuation = VerifiPass ? 1 : 0;
    Console.Write(VerifiPass ? "" : "Пароль не содержит знаков препинания / ");
    VerifiPass = pass.Any(char.IsSymbol);
    int passSymbol = VerifiPass ? 1 : 0;
    Console.WriteLine(VerifiPass ? "" : "Пароль не содержит символов");
    if ((passLetter + passDigit + passPunctuation + passSymbol) == 4)
    {
        Console.WriteLine("-----------------\n| Пароль принят |\n-----------------");
    }
    else
    {
        Console.WriteLine("--------------------\n| Пароль не принят |\n--------------------");
    }
}
else
{
    Console.WriteLine("Пароль содержит меньше 8 символов");
}