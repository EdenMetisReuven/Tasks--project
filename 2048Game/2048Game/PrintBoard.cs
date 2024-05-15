using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    class PrintBoard
    {
        public void printBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    Console.Write(board[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine();
                Console.WriteLine("--------");

            }
        }
    }
}
