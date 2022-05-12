using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.print();
            while (true)
            {
                Thread.Sleep(800);
                game.print();
                var command = Console.ReadKey().Key;
                switch (command)
                {
                    case ConsoleKey.RightArrow:
                        game.snake.move_x(1);
                        break;
                    default:
                        break;
                }
            }
            /*
            Console.WriteLine(@"
%%%%%%%%%%
%%%%%%%%%%
%%%%%%%%%%
%%%%%%%%%%
%%%%%%%%%%
                ");
            */
        }
    }
}
