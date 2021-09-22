using System;
using System.Collections.Generic;
using System.Text;

namespace Group1Game
{
     class Rock: MapObject
    {

        public Rock(int length, int height):base(length,height)
        {
        }

        public void Size(Board board)
        {
            int a, b;
            Random myTal = new Random();
            a= myTal.Next(1, board.BoardSize-1);
            b= myTal.Next(1, board.BoardSize-1);
            board.Boardfield[a, b] = "O";

            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Length; j++)
                {
                    if (i + a >= board.BoardSize || j + b >= board.BoardSize)
                        continue;
                    board.Boardfield[i + a, j + b] = "O";
                }

        }
    }
}
