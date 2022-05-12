using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Game
    {
        public Snake snake;
        Fruit fruit;
        StringBuilder sb;
        public Game()
        {
            sb = new StringBuilder();
            snake = new Snake();
        }
        public void print() {
            int field_size = 10 * 5;
            sb.Clear();
            for (int y = 0; y < 75; y++)
            {
                for (int x = 0; x < 15; x++)
                {
                    int y_pos = y/5;
                    int x_pos = x;
                    Vector2d pos = new Vector2d(x_pos, y_pos);
                    string texture = "          ";
                    foreach (var segment in snake.GetSegments())
                    {
                        if (segment.pos.IsTheSame(ref pos))
                        {
                            texture = segment.GetTexture()[y % 5];
                        }
                    }
                    
                    sb.Append(texture);
                }
                sb.Append("\n");
            }
            FastConsole.WriteLine(sb.ToString());
            Console.Clear();
            FastConsole.Flush();
        }
    }
}
