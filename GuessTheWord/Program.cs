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
    Console.WriteLine($"\nВведите букву (у вас попыток: {attempts}) ");
    char PlayerInput = char.ToLower(char.Parse(Console.ReadLine() ?? " "));
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

    if (Found == true)
    {
        Console.WriteLine("Ура! Вы угадали букву!");
    }
    else
    {
        Console.WriteLine("Вы не угадали!");
        attempts--;
    }

    Console.WriteLine($"Ваше слово: {new string(Mystery)}");

    // Проверка на победу
    if (!new string(Mystery).Contains('_'))
    {
        Winner = true;
        Console.Clear();
        Console.WriteLine("Победа!");
        Console.WriteLine($"Вы угадали слово: {new string(Mystery)}");
        break;
    }
}
while (attempts > 0);

if (Winner == false)
{
    Console.WriteLine($"К сожалению, вы проиграли. Загаданное слово было: {Words}");
}
