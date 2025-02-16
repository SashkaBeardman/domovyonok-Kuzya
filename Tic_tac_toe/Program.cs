using System.Numerics;
using System.Xml;

    bool Game = true;
    char Player = 'X';

    char[] field = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    int attempts = field.Length;//длинна массива

    while (Game)
    {
        Console.Clear();
        Console.WriteLine($"{field[0]} | {field[1]} | {field[2]} ");
        Console.WriteLine("---------");
        Console.WriteLine($"{field[3]} | {field[4]} | {field[5]} ");
        Console.WriteLine("---------");
        Console.WriteLine($"{field[6]} | {field[7]} | {field[8]} ");
        Console.WriteLine($"Игрок '{Player}', введите номер ячейки (1-9):");

    if (!int.TryParse(Console.ReadLine(), out int move) || move < 1 || move > 9)
    {
        Console.WriteLine("Некорректный ввод! Нажмите Enter и попробуйте снова.");
        Console.ReadLine();
        continue;
    }

    int index = move - 1;

    if (field[index] == 'X' || field[index] == 'O')
    {
        Console.WriteLine("Ячейка уже занята! Нажмите Enter и выберите другую.");
        Console.ReadLine();
        continue;
    }
    field[index] = Player;
    attempts--;

    if (field[0] == field[1] && field[1] == field[2])//Горизонталь 1
        {
            Console.WriteLine($"Игрок {field[0]} виграл!");
            Game = false;
        }
        else if (field[3] == field[4] && field[4] == field[5])//Горизонталь 2
        {
            Console.WriteLine($"Игрок {field[3]} виграл!");
            Game = false;
        }
        else if (field[6] == field[7] && field[7] == field[8])//Горизонталь 3
        {
            Console.WriteLine($"Игрок {field[6]} виграл!");
            Game = false;
        }
        else if (field[0] == field[3] && field[3] == field[6])//Вертикаль 1
        {
            Console.WriteLine($"Игрок {field[0]} виграл!");
            Game = false;
        }
        else if (field[1] == field[4] && field[4] == field[7])//Вертикаль 2
        {
            Console.WriteLine($"Игрок {field[1]} виграл!");
            Game = false;
        }
        else if (field[2] == field[5] && field[5] == field[8])//Вертикаль 3
        {
            Console.WriteLine($"Игрок {field[2]} виграл!");
            Game = false;
        }else if (field[0] == field[4] && field[4] == field[8])//Диагональ 1
        {
            Console.WriteLine($"Игрок {field[0]} виграл!");
            Game = false;
        }else if (field[2] == field[4] && field[4] == field[6])//Диагональ 2
        {
            Console.WriteLine($"Игрок {field[2]} виграл!");
            Game = false;
        }
        else if (attempts == 0)
        {
            Console.WriteLine("Ничья!");
            Game = false;
        }
        else
        {
            Player = (Player == 'X') ? 'O' : 'X';
        }

}
