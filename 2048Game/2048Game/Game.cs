using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
     class Game
    {
        public Direction direction {  get; set; }

        Board board = new Board();
        MovingTools movingTools = new MovingTools();
        public int[,] Board {  get; set; }
        public GameStatus gameStatus { get; set; }
        public int Points { get; protected set; }

        public Game() 
        { 
            Board = board.Data;
            gameStatus = new GameStatus();
            direction = new Direction();

        }
        public void GameStart()
        {
            Board = board.StartTile();
        }
        public void Move()
        { 
            if (gameStatus != GameStatus.Lost)
            {
                Points = board.Move(direction);  
            }
        }
        public void userDirection(ConsoleKey userChooseDirection)
        {
            
            while (userChooseDirection != ConsoleKey.LeftArrow && userChooseDirection != ConsoleKey.RightArrow &&
                userChooseDirection != ConsoleKey.UpArrow && userChooseDirection != ConsoleKey.DownArrow)
            
                {
                    Console.WriteLine("\n please choose a valid direction (UpArrow, DownArrow, LeftArrow or RightArrow)!!");
                    userChooseDirection = Console.ReadKey().Key;

                }
                if (userChooseDirection == ConsoleKey.LeftArrow)
                {
                    direction = Direction.Left;
                    
                }
                if (userChooseDirection == ConsoleKey.RightArrow)
                {
                    direction = Direction.Right;
                    

                }
                if (userChooseDirection == ConsoleKey.UpArrow)
                {
                    direction = Direction.Up;
                 ;
                }
                if (userChooseDirection == ConsoleKey.DownArrow)
                {
                    direction = Direction.Down;
                    ;
                }
            
        }

    }
}
