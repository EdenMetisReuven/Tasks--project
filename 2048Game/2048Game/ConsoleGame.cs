using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048Game
{
    class ConsoleGame
    {
        public static void Main(string[] args)
        {
            Board board = new Board();
            Game game = new Game();
            PrintBoard print = new PrintBoard();
            game.GameStart();
            print.printBoard(game.Board);
            GameStatus status = new GameStatus();
            status = board.Status(game.Board);

            while (status!=GameStatus.Lost && status!=GameStatus.Win)
            {
                
                if (status == GameStatus.Idle)
                {
                    Console.WriteLine("Click direction");
                    ConsoleKey userChooseDirection = Console.ReadKey().Key;
                    game.userDirection(userChooseDirection);
                    game.Move();
                    print.printBoard(game.Board);
                    Console.WriteLine($"Your score is : {game.Points}");
                }
                else 
                {
                    break;
                }
                status = board.Status(game.Board);
            }
            if (status == GameStatus.Win)
            {
                Console.WriteLine($"Your score is : {game.Points}");
                Console.WriteLine("You WON!");
                Console.WriteLine("Good Job");
            }
            if (status == GameStatus.Lost)
            {
                Console.WriteLine($"Your score is : {game.Points}");
                Console.WriteLine("You Lost");
            }
            
        }
       
    }
}
