using System;
using System.Collections.Generic;
using System.Text;

namespace Group1Game
{
    class Tile
    {
        public int Row { get; set; }
        public int Col { get; set; }
        public int TimesVisited { get; set; }

        public Tile(int col, int row, int timesVisited)
        {
            Row = row;
            Col = col;
            TimesVisited = timesVisited;
        }
    }
}
