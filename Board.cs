using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading;

namespace Group1Game
{
    public class Board
    {
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int BoardSize { get; set; }
        public string[,] Boardfield { get; set; }
        public Player CurrentPlayer { get; set; }


        public void ResetBoard()
        {
            Console.WriteLine("Game is starting!");

            for (int x = 0; x < BoardSize-1; x++)
            {
                for (int y = 0; y < BoardSize-1; y++)
                {
                    Boardfield[x, y] = ".";
                    //Console.SetCursorPosition(x, y);
                }
            }

            Console.WriteLine("\n\nPress any key to exit...");
        }

        public bool IsVictoryPossible(string[,] boardField)
        {
            int col = 1, row = 0;

            bool isInsideCol = Cols > col && col > 0;
            bool isInsideRow = Rows > row && row > 0;

            while (boardField[col, row] != "mål" /* Ändra till det tecknet som signalerar mål.*/ )
            {
                if (boardField[col, row] == "O" && isInsideCol && isInsideCol) { row++; col--; } // Gå höger ifall upp är blockerad.
                if (boardField[col, row] == "O" && isInsideCol && isInsideCol) { }
            }

            throw new NotImplementedException();  // Tas Bort!!
        }

        public void PrintBoard(Player currentPlayer)
        {
            Console.Clear();
            Console.WriteLine();

            // Do { ... } while( IsVictoryPossbile == true );

            for (int x = BoardSize-1; x >= 0; x--)
            {
                for (int y = 0; y < BoardSize; y++)
                {
                    if (x == currentPlayer.playerRow && y == currentPlayer.playerColumn)
                    {
                        Boardfield[x, y] = "X"; //sätta initialvärde istället?
                    }
                    else if (Boardfield[x, y] == "O")
                    {
                        Boardfield[x, y] = "O";
                    }
                    else if (Boardfield[x, y] == "H")
                    {
                        Boardfield[x, y] = "H";
                    }
                    else
                        Boardfield[x, y] = ".";
                    Console.Write(Boardfield[x,y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            //Console.WriteLine($"Hello i am test");
        }

        public void PlayerMovement(Player currentplayer, Player secondPlayer)
        {
            ConsoleKey input = Console.ReadKey().Key;
            switch (input)
            {
                case ConsoleKey.A:
                    PlayerGoLeft(currentplayer);
                    break;
                case ConsoleKey.S:
                        PlayerGoDown(currentplayer);
                    break;
                case ConsoleKey.D:
                    PlayerGoRight(currentplayer);
                    break;
                case ConsoleKey.W:
                     PlayerGoUp(currentplayer);
                    break;
            }
        }

        public void PlayerGoRight(Player currentPlayer)
        {
            if ((IsPositionWalkable(currentPlayer.playerRow, currentPlayer.playerColumn + 1)))
            {
               // if (currentPlayer.playerColumn < BoardSize - 1)
                    currentPlayer.playerColumn++;
            }

        }

        public void PlayerGoLeft(Player currentPlayer)
        {
            if ((IsPositionWalkable(currentPlayer.playerRow, currentPlayer.playerColumn - 1)))
            {
               // if (currentPlayer.playerColumn > 0)
                    currentPlayer.playerColumn--;
            }
        }

        public void PlayerGoUp(Player currentPlayer)
        {
            if (IsPositionWalkable(currentPlayer.playerRow + 1, currentPlayer.playerColumn))
            {
               // if (currentPlayer.playerRow < BoardSize - 1)
                    currentPlayer.playerRow++;
            }

        }

        public void PlayerGoDown(Player currentPlayer)
        {
            if (IsPositionWalkable(currentPlayer.playerRow - 1, currentPlayer.playerColumn))
            {
               // if (currentPlayer.playerRow > 0)
                    currentPlayer.playerRow--;
            }
        }

        public bool IsPositionWalkable(int x, int y)
        {
            if (x < 0 || y < 0 || x >= BoardSize || y >= BoardSize)
            {
                return false;
            }

            return Boardfield[x, y] == "."; // || Boardfield[x, y] == "H"
        }

        public Board()
        {
            Rows = 5;
            Cols = 5;
        }
        public Board(int boardSize)
        {
            BoardSize = boardSize;
            Boardfield = new string[boardSize, boardSize];
        }
    }
}
