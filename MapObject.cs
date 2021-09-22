using System;
using System.Collections.Generic;
using System.Text;

namespace Group1Game
{
    abstract class MapObject
    {
        public int Length { get; set; }
        public int Height { get; set; }

        public MapObject(int length, int height)
        {
            Length = length;
            Height = height;

        }
        //public abstract void Size(Board board);
    }
}
