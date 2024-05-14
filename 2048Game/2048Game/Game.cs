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
        Board board = new Board();
        MovingTools movingTools = new MovingTools();
        public int[,] Board {  get; set; }
        public GameStatus gameStatus { get; set; }
        public int Points { get; protected set; }

        public Game() 
        { 
            Board = board.Data;
            gameStatus = new GameStatus();
           // Points = movingTools.score;
        }
        public void GameStart()
        {
            Board = board.StartTile();
        }
        public void Move(Direction direction)
        { 
            if (gameStatus != GameStatus.Lost)
            {
                Points = board.Move(direction);  
            }
        }
        
       
    }
}
