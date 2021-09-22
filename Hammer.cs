using System;
using System.Collections.Generic;
using System.Text;

namespace Group1Game
{
    class Hammer : Item
    {
        public Hammer(int length, int height):base(length, height)
        {
            ItemMarker = "H";
        }
        //public Hammer(string marker) : base(marker)
        //{
        //    Marker = "H";
        //}
    }
}
