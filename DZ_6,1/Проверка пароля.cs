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
