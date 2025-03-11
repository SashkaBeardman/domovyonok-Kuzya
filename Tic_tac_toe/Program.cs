using System;

class TicTacToe
{
    static int size = 5;
    static char[,] board = new char[size, size];
    static char[] players = { 'X', 'O', '△', '□' }; // Символы для 3-4 игроков
    static int playerCount;

    static void Main()
    {
        Console.Write("Введите количество игроков (3 или 4): ");
        playerCount = Math.Clamp(Convert.ToInt32(Console.ReadLine()), 3, 4);

        InitBoard();
        PlayGame();
    }

    static void InitBoard()
    {
        for (int i = 0; i < size; i++)
            for (int j = 0; j < size; j++)
                board[i, j] = '.';
    }

    static void PlayGame()
    {
        int moves = 0;
        bool gameWon = false;
        while (moves < size * size)
        {
            PrintBoard();
            char currentPlayer = players[moves % playerCount];

            Console.WriteLine($"\nХод игрока {currentPlayer}. Введите координаты (ряд):");
            int row = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.WriteLine($"\nХод игрока {currentPlayer}. Введите координаты (колонку):");
            int col = Convert.ToInt32(Console.ReadLine()) - 1;

            if (IsValidMove(row, col))
            {
                board[row, col] = currentPlayer;
                moves++;

                if (CheckWin(row, col, currentPlayer))
                {
                    PrintBoard();
                    Console.WriteLine($"\n Игрок {currentPlayer} победил!");
                    gameWon = true;
                    break;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ход! Попробуйте снова.");
            }
        }

        if (!gameWon)
        {
            PrintBoard();
            Console.WriteLine("\nНичья!");
        }
    }

    static bool IsValidMove(int row, int col)
    {
        return row >= 0 && row < size && col >= 0 && col < size && board[row, col] == '.';
    }

    static bool CheckWin(int row, int col, char player)
    {
        return CheckDirection(row, col, player, 1, 0) ||  // Горизонталь
               CheckDirection(row, col, player, 0, 1) ||  // Вертикаль
               CheckDirection(row, col, player, 1, 1) ||  // Диагональ \
               CheckDirection(row, col, player, 1, -1);   // Диагональ /
    }

    static bool CheckDirection(int row, int col, char player, int dRow, int dCol)
    {
        int count = 1;
        count += CountInDirection(row, col, player, dRow, dCol);
        count += CountInDirection(row, col, player, -dRow, -dCol);
        return count >= 4;
    }

    static int CountInDirection(int row, int col, char player, int dRow, int dCol)
    {
        int r = row + dRow, c = col + dCol, count = 0;
        while (r >= 0 && r < size && c >= 0 && c < size && board[r, c] == player)
        {
            count++;
            r += dRow;
            c += dCol;
        }
        return count;
    }

    static void PrintBoard()
    {
        Console.Clear();
        Console.WriteLine("\n  " + string.Join(" ", Enumerable.Range(1, size)));
        for (int i = 0; i < size; i++)
        {
            Console.Write((i + 1) + " ");
            for (int j = 0; j < size; j++)
            {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
