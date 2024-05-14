using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace _2048Game
{
    class Board
    {
        MovingTools moving = new MovingTools();
        public int[,] Data { get; protected set; }

        public Board()
        {
            Data = new int[4, 4];
        }

        public int[,] GameBoard()
        {

            for (int i = 0; i < Data.GetLength(0); i++)
            {
                for (int j = 0; j < Data.GetLength(1); j++)
                {
                    Data[i, j] = 0;
                }
            }
            return Data;
        }
        public int[,] StartTile()
        {
            EnterGameTile(Data);
            EnterGameTile(Data);
            return Data;

        }

        private int[,] EnterGameTile(int[,] gameBoard)
        {
            int[] gameTile = { 2, 4 };
            Random rnd = new Random();
            int line = rnd.Next(0, gameBoard.GetLength(0));
            int column = rnd.Next(0, gameBoard.GetLength(1));
            int twoOrFour = rnd.Next(0, 2);
            if (gameBoard[line, column] == 0)
            {

                gameBoard[line, column] = gameTile[twoOrFour];
            }
            else
            {
                EnterGameTile(gameBoard);
            }
            return gameBoard;
        }
        public int Move(Direction direction)
        {
            
            if (direction == Direction.Left)
            {
                Data = moving.MovingTileLeft(Data);
                Data = EnterGameTile(Data);
            }
            if (direction == Direction.Right)
            {
                Data = moving.MovingTileRight(Data);
                Data = EnterGameTile(Data);

            }
            if (direction == Direction.Up)
            {
                Data = moving.MovingTileUp(Data);
                Data = EnterGameTile(Data);

            }
            if (direction == Direction.Down)
            {
                Data = moving.MovingTileDown(Data);
                Data = EnterGameTile(Data);

            }

            Console.WriteLine("The score is: ");
            return moving.score;
        }
        public GameStatus Status(int[,] gameBoard)
        {
            int sumFallTile = 0;
            int column = gameBoard.GetLength(0);
            int line = gameBoard.GetLength(1);
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                    if (gameBoard[i, j] == 2048)
                    {
                        return GameStatus.Win;
                    }
                    if (gameBoard[i, j] != 0)
                    {
                        sumFallTile++;
                    }
                    else
                    {
                        return GameStatus.Idle;
                    }

                }
            }
            if (sumFallTile == line * column)
            {
                for (int i = 0; i < column; i++)
                {
                    for (int j = 0; j < line; j++)
                    {
                        if (gameBoard[i, j] == gameBoard[i + 1, j])
                            return GameStatus.Idle;
                        if (gameBoard[i, j] == gameBoard[i, j - 1])
                            return GameStatus.Idle;
                        if (gameBoard[i, j] == gameBoard[i, j + 1])
                            return GameStatus.Idle;
                        if (gameBoard[i, j] == gameBoard[i - 1, j])
                            return GameStatus.Idle;
                    }
                }
            }
            return GameStatus.Lost;

        }

    }
}
