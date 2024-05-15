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

            while (board.Status()!=GameStatus.Lost|| board.Status()!=GameStatus.Win)
            {
                if (board.Status() == GameStatus.Idle)
                {
                    Console.WriteLine("Click direction");
                    ConsoleKey userChooseDirection = Console.ReadKey().Key;
                    game.userDirection(userChooseDirection);
                    game.Move();
                    print.printBoard(game.Board);
                    Console.WriteLine($"Your score is : {game.Points}");
                }
            }
            if (board.Status() == GameStatus.Win)
            {
                Console.WriteLine($"Your score is : {game.Points}");
                Console.WriteLine("You WON!");
                Console.WriteLine("Good Job");
            }
            if (board.Status() == GameStatus.Lost)
            {
                Console.WriteLine($"Your score is : {game.Points}");
                Console.WriteLine("You Lost");
            }
            
        }
       
    }
}
