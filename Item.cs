using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Group1Game
{
    class Item : MapObject, ICollectable
    {
        public string ItemMarker { get; set; }

       // public int NumberOfTimesUsed { get; set; }
       // public bool IsAvailable { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Item(int length, int height):base(length, height)
        {
            Length = 1;
            Height = 1;
        }


        public void PlaceFixedItem(Board board)
        {
            if (board.Boardfield[3, 3] == ".")
            {
                board.Boardfield[3, 3] = ItemMarker;
            }
        }

        public void PlaceRandomItem(Board board)
        {
            int a, b;
            Random myTal = new Random();
            a = myTal.Next(0, board.BoardSize);
            b = myTal.Next(0, board.BoardSize);
            board.Boardfield[a, b] = ItemMarker;
        }

    }
}
