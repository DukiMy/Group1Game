using System;

namespace Group1Game
{
    class Program
    {


        static void Main(string[] args)
        {
            int boardSize = 10;

            Player player1 = new Player();
            Player player2 = new Player();
            Rock rock = new Rock(2, 2);
            Rock rock1 = new Rock(3, 2);
            Rock rock2 = new Rock(1, 2);

            Hammer hammer = new Hammer(2, 2); //nytt

            Board currentGame = new Board(boardSize);
            currentGame.ResetBoard();
            rock.Size(currentGame);
            rock1.Size(currentGame);
            rock2.Size(currentGame);

            hammer.PlaceFixedItem(currentGame);
            hammer.PlaceRandomItem(currentGame); //nytt

            currentGame.PrintBoard(player1);
            player1.currentPos = (0,0);
            player2.currentPos = (0, 1);

            while(true)
            {
                currentGame.PlayerMovement(player1, player2);
                currentGame.PrintBoard(player1);
            }
        }
    }
}