using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Group1Game
{
    public class Player
    {
        //public int[,] currentPosition { get; set; } = new int[5, 5];
        //(int, int) currentPos = (0, 0);
        int x = 0;
        int y = 0;
        public (int, int) currentPos { get; set; } = (0,0);
        public int playerRow { get; set; } = 0;
        public int playerColumn { get; set; } = 0;
        public int NumberOfMoves { get; set; } = 0;

        public Player()
        {

        }


    }
}
