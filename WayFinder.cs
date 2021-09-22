/*
 * Klassen förutsätter att spelaren startar från nedersta hörnet åt vänster.
 * 
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace Group1Game
{
    class WayFinder
    {
        public string[,] Map { get; set; }

        public string Obstacle { get; set; } = "O";

        public void MoveDown()
        {

        }

        public void MoveRight()
        {

        }

        public void MoveUp()
        {

        }

        public void CheckDown()
        {

        }

        public void CheckRight()
        {

        }

        public void CheckUpp()
        {

        }

        public WayFinder(string[,] map)
        {
            Map = map;
        }

    }

}
