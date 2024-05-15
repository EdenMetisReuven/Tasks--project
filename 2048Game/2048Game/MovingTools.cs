using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    class MovingTools
    {
        public int score { get; set; }
        public MovingTools()
            {
            score = 0;
            }
        public int[,] MovingTileLeft(int[,] gameBoard)
        {
            int x = 1;
            int tile = 0;
            int column = gameBoard.GetLength(0);
            int line = gameBoard.GetLength(1) - 1;
            for (int i = 0; i < column; i++)
            {
                for (int j = 1; j <= line; j++)
                {
                    tile = gameBoard[i, j];
                    x = 1;
                    while (j - x >= 0)
                    {

                        if (gameBoard[i, j - x] == 0)
                        {
                            gameBoard[i, j - x] = tile;
                            gameBoard[i, j - x + 1] = 0;

                            x++;
                        }
                        else

                            if (gameBoard[i, j - x] == tile)
                        {

                            score += tile * 2;
                            gameBoard[i, j - x] = tile * 2;
                            gameBoard[i, j - x + 1] = 0;
                            if (j != line)
                            {
                                gameBoard[i, j - x + 1] = 1;
                            }
                            break;

                        }
                        else
                        if (gameBoard[i, j - x] == 1)
                        {

                            gameBoard[i, j - x] = tile;
                            gameBoard[i, j - x + 1] = 0;

                            break;
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }
            return gameBoard;
        }
        public int[,] MovingTileRight(int[,] gameBoard)
        {
            int x = 1;
            int tile = 0;
            int column = gameBoard.GetLength(0);
            int line = gameBoard.GetLength(1) - 1;
            for (int i = 0; i < column; i++)
            {
                for (int j = line - 1; j >= 0; j--)
                {
                    tile = gameBoard[i, j];
                    x = 1;
                    while (j + x <= line)
                    {

                        if (gameBoard[i, j + x] == 0)
                        {
                            gameBoard[i, j + x] = tile;
                            gameBoard[i, j + x - 1] = 0;

                            x++;
                        }
                        else

                            if (gameBoard[i, j + x] == tile)
                        {

                            score += tile * 2;
                            gameBoard[i, j + x] = tile * 2;
                            gameBoard[i, j + x - 1] = 0;
                            if (j != 0)
                            {
                                gameBoard[i, j + x - 1] = 1;
                            }
                            break;

                        }
                        else
                        if (gameBoard[i, j + x] == 1)
                        {

                            gameBoard[i, j + x] = tile;
                            gameBoard[i, j + x - 1] = 0;

                            break;
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }
            
            return gameBoard;
        }

        public int[,] MovingTileUp(int[,] gameBoard)
        {
            int x = 1;
            int tile = 0;
            int column = gameBoard.GetLength(0) - 1;
            int line = gameBoard.GetLength(1);
            for (int j = 0; j < line; j++)
            {
                for (int i = 1; i <= column; i++)
                {
                    tile = gameBoard[i, j];
                    x = 1;
                    while (i - x >= 0)
                    {

                        if (gameBoard[i - x, j] == 0)
                        {
                            gameBoard[i - x, j] = tile;
                            gameBoard[i - x + 1, j] = 0;

                            x++;
                        }
                        else

                            if (gameBoard[i - x, j] == tile)
                        {

                            score += tile * 2;
                            gameBoard[i - x, j] = tile * 2;
                            gameBoard[i - x + 1, j] = 0;
                            if (i != column)
                            {
                                gameBoard[i - x + 1, j] = 1;
                            }
                            break;

                        }
                        else
                        if (gameBoard[i - x, j] == 1)
                        {

                            gameBoard[i - x, j] = tile;
                            gameBoard[i - x + 1, j] = 0;

                            break;
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }
            return gameBoard;
        }
        public int[,] MovingTileDown(int[,] gameBoard)
        {
            int x = 1;
            int tile = 0;
            int column = gameBoard.GetLength(0) - 1;
            int line = gameBoard.GetLength(1);
            for (int j = 0; j < line; j++)
            {
                for (int i = column - 1; i >= 0; i--)
                {
                    tile = gameBoard[i, j];
                    x = 1;
                    while (x + i <= column)
                    {
                        if (gameBoard[i + x, j] == 0)
                        {
                            gameBoard[i + x, j] = tile;
                            gameBoard[i + x - 1, j] = 0;

                            x++;
                        }
                        else

                            if (gameBoard[i + x, j] == tile)
                        {
                           
                            score += tile*2;
                            gameBoard[i + x, j] = tile * 2;
                            gameBoard[i + x - 1, j] = 0;
                            if (i != 0)
                            {
                                gameBoard[i + x - 1, j] = 1;
                            }
                            break;

                        }
                        else
                        if (gameBoard[i + x, j] == 1)
                        {

                            gameBoard[i + x, j] = tile;
                            gameBoard[i + x - 1, j] = 0;

                            break;
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }
            return gameBoard;
        }
    }
}
