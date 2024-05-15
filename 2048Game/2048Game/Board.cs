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
       public bool sumFallTile;
        MovingTools moving = new MovingTools();
        public int[,] Data { get; protected set; }
        public int Point {  get; protected set; }

        public Board()
        {
            Data = new int[4, 4];
            Point = 0;
            sumFallTile = false;
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
            Status(Data);
            if (direction == Direction.Left)
            {
                Data = moving.MovingTileLeft(Data);
                Point = moving.score;
                Status(Data);
                if (sumFallTile == false)
                {
                    Data = EnterGameTile(Data);
                }
            }
            
            if (direction == Direction.Right )
            {
                Data = moving.MovingTileRight(Data);
                Point = moving.score;
                Status(Data);
                if (sumFallTile == false)
                {
                    Data = EnterGameTile(Data);
                }
            }
           
            if (direction == Direction.Up)
            {
                Data = moving.MovingTileUp(Data);
                Point = moving.score;
                Status(Data);
                if (sumFallTile == false)
                {
                    Data = EnterGameTile(Data);
                }
            }
           
            if (direction == Direction.Down )
            {
                Data = moving.MovingTileDown(Data);
                Point = moving.score;
                Status(Data);
                if (sumFallTile == false)
                {
                    Data = EnterGameTile(Data);
                }
            }
           
            return Point;
        }
        public GameStatus Status(int[,] Data)
        {
            int sum = 0;
            int column = Data.GetLength(0);
            int line = Data.GetLength(1);
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < line; j++)
                {
                   
                    if (Data[i, j] == 2048)
                    {
                        return GameStatus.Win;
                    }
                    if (Data[i,j] == 0)
                    {
                        sumFallTile = false;
                        return GameStatus.Idle;
                    }

                }
            }
           
                sumFallTile = true;

            for (int x = 1; x < column - 1; x++)
            {
                for (int y = 1; y < line - 1; y++)
                {

                    if (Data[x, y] == Data[x + 1, y])
                    {

                        return GameStatus.Idle;
                    }


                    if (Data[x, y] == Data[x, y - 1])
                    {
                        return GameStatus.Idle;
                    }


                    if (Data[x, y] == Data[x, y + 1])
                    {
                        return GameStatus.Idle;
                    }


                    if (Data[x, y] == Data[x - 1, y])
                    {
                        return GameStatus.Idle;
                    }

                }
            }
                for (int c = 0; c < line-1; c++)
                {
                    if (Data[0, c] == Data[0,c+1])
                    {
                        return GameStatus.Idle;
                    }
                    if (Data[column -1, c] == Data[column -1, c + 1])
                    {
                        return GameStatus.Idle;
                    }
                }
                for (int b = 0; b < line - 1; b++)
                {
                    if (Data[b, 0] == Data[b +1, 0])
                    {
                        return GameStatus.Idle;
                    }
                    if (Data[b, line - 1] == Data[b+1, line - 1])
                    {
                        return GameStatus.Idle;
                    }
                }
            
            
            return GameStatus.Lost;

        }

    }
}
