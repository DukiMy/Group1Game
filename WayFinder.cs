/*
 * Endast "AreEdgesClear()" kan nås av andra klasser.
 * Den tar en spelkarta i form av string[,] och en array av hinder.
 * Den returnerar en ett boll värde beroende på om alla kanter är fria från hinder eller ej.
 * Durim står bakom denna klass och tar fullt ansvar för den.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Group1Game
{
    static class WayFinder
    {
        private static string[,] grid;

        private static int rowAmount = grid.GetLength(0);

        private static int colAmount = grid.GetLength(1);

        private static string[] obstaclesArr;

        private static bool IsRightColFree()
        {
            bool result = true;                                                             // __________________
                                                                                            // | | | | | | | | |·|
            for ( int row = 0; row < rowAmount; row++ )                                     // | | | | | | | | |·|
            {                                                                               // | | | | | | | | |·|
                for (int i = 0; i < obstaclesArr.Length; i++)                               // | | | | | | | | |·|
                {                                                                           // | | | | | | | | |·|
                    if (grid[row, rowAmount] == obstaclesArr[i]) { result = false; break; } // | | | | | | | | |·|
                }                                                                           // | | | | | | | | |·|
            }

            return result;
        }

        private static bool IsLeftColFree()
        {
            bool result = true;                                                         // __________________
                                                                                        // |·| | | | | | | | |
            for ( int row = 0; row < rowAmount; row++)                                  // |·| | | | | | | | |
            {                                                                           // |·| | | | | | | | |
                for (int i = 0; i < obstaclesArr.Length; i++)                           // |·| | | | | | | | |
                {                                                                       // |·| | | | | | | | |
                    if (grid[row, 0] == obstaclesArr[i]) { result = false; break; }     // |·| | | | | | | | |
                }                                                                       // |·| | | | | | | | |
            }

            return result;
        }

        private static bool IsLowerRowFree()                                            // __________________
        {                                                                               // | | | | | | | | | |
            bool result = true;                                                         // | | | | | | | | | |
                                                                                        // | | | | | | | | | |
            for ( int col = 0; col < colAmount; col++)                                  // | | | | | | | | | |
            {                                                                           // | | | | | | | | | |
                for (int i = 0; i < obstaclesArr.Length; i++)                           // | | | | | | | | | |
                {                                                                       // |·|·|·|·|·|·|·|·|·|
                    if (grid[col, rowAmount] == obstaclesArr[i]) { result = false; break; }
                }
            }

            return result;
        }

        private static bool IsUpperRowFree()                                            // __________________
        {                                                                               // |·|·|·|·|·|·|·|·|·|
            bool result = true;                                                         // | | | | | | | | | |
                                                                                        // | | | | | | | | | |
            for (int col = 0; col < colAmount; col++)                                   // | | | | | | | | | |
            {                                                                           // | | | | | | | | | |
                for (int i = 0; i < obstaclesArr.Length; i++)                           // | | | | | | | | | |
                {                                                                       // | | | | | | | | | |
                    if (grid[col, 0] == obstaclesArr[i]) { result = false; break; }     // | | | | | | | | | |
                }
            }

            return result;
        }

        public static bool AreEdgesClear(string[,] twoDimArray, string[] obstacles)
        {
            obstaclesArr = obstacles;
            grid = twoDimArray;

            if ( IsUpperRowFree() && IsLowerRowFree() && IsLeftColFree() && IsRightColFree() )
            {
                return true;
            }

            return false;
        }
    }
}
