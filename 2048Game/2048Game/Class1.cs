using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    class Class1
    {
        public static void Main(string[] args)
        {
            Menu directionMenu = new Menu();
            Board game = new Board();
            //int[,] gameBoard = game.GameBoard();
            //gameBoard = game.EnterGameTile();
            //gameBoard = game.EnterGameTile(gameBoard);
            //gameBoard = game.EnterGameTile(gameBoard);
            //PrintBoard(gameBoard);
            //Console.WriteLine("Part2");
            // gameBoard = game.MovingTile(gameBoard);
            //PrintBoard(gameBoard);
            //int direction = directionMenu.DirectionSelection();
            //gameBoard = game.MovingTile(gameBoard, direction);
            PrintBoard(game.StartTile());
            Console.WriteLine("Part2");
            PrintBoard(game.MovingTileRight(game.Data));
        }
        public static void PrintBoard(int[,] gameBoard)
            {
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    Console.Write(gameBoard[i, j]);
                    Console.Write("|");
                }
                Console.WriteLine();
                Console.WriteLine("--------");

            }
        }
    }
}
