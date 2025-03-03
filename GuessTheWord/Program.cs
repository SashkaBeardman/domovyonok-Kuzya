Console.OutputEncoding = System.Text.Encoding.UTF8;
string[] Vocabulary = { "Карандаш", "Книга", "Ластик", "Ручка" };
Random rnd = new Random();
int Random = rnd.Next(0, Vocabulary.Length);
string Words = Vocabulary[Random].ToLower();
bool Winner = false;
bool Found = false;

char[] Mystery = new char[Words.Length];
for (int i = 0; i < Mystery.Length; i++)
{
    Mystery[i] = '_';
}

int attempts = Words.Length; // Кол-во попыток равно длине слова

Console.WriteLine($"Добро пожаловать на Поле чудес, ваше слово состоит из {attempts} букв.");

do
{
    Console.WriteLine($"\nВведите букву: ");
    string input = Console.ReadLine();

    if (string.IsNullOrEmpty(input) || input.Length > 1)
    {
        Console.WriteLine("Ошибка: введите одну букву.");
        continue;
    }

    char PlayerInput = char.ToLower(input[0]);
    Console.Clear();

    Found = false;

    for (int i = 0; i < Words.Length; i++)
    {
        if (Words[i] == PlayerInput && Mystery[i] == '_')
        {
            Mystery[i] = PlayerInput;
            Found = true;
        }
    }

    GuessedLetterWords(Found,ref attempts);

    StatusWords(Mystery);
    Console.WriteLine($"\n\n(у вас попыток: {attempts})");

    UserWin(Words,ref Winner, Mystery);

    if (Winner)
    {
        break;
    }


}
while (attempts > 0);

if (Winner == false)
{
    Console.WriteLine($"К сожалению, вы проиграли. Загаданное слово было: {Words}");
}

static void UserWin(string Words, ref bool Winner, char[] Mystery)
{
    if (!Mystery.Contains('_'))
    {
        Winner = true;
        Console.Clear();
        Console.WriteLine("Победа!");
        Console.WriteLine($"Вы угадали слово: {Words}");
    }
}

static void StatusWords(char[] Mystery)
{
    Console.Write("Ваше слово:");
    foreach (var i in Mystery)
    {
        Console.Write(i);
    }
}

static void GuessedLetterWords(bool Found,ref int attempts)
{
    if (Found)
    {
        Console.WriteLine("Ура! Вы угадали букву!");
    }
    else
    {
        Console.WriteLine("Вы не угадали!");
        attempts--;
    }
}