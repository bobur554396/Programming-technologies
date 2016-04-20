using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Snake.models;
using System.Threading;
using System.Threading.Tasks;


namespace Snake
{
    class Program
    {
        public enum Direction { up, down, left, right };
        public static Direction direction;

        static void Main(string[] args)
        {
            Game.Init();
            Game.LoadLevel(1);

            Timer t1 = new Timer(MoveSnake);
            t1.Change(0, 100);

            while (Game.isActive)
            {
                Game.Draw();

                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        direction = Direction.up;
                        break;
                    case ConsoleKey.DownArrow:
                        direction = Direction.down;
                        break;
                    case ConsoleKey.LeftArrow:
                        direction = Direction.left;
                        break;
                    case ConsoleKey.RightArrow:
                        direction = Direction.right;
                        break;
                    case ConsoleKey.Escape:
                        Game.isActive = false;
                        break;
                    case ConsoleKey.F2:
                        Game.Save();
                        break;
                    case ConsoleKey.F3:
                        Game.Resume();
                        break;
                }
            }
            Console.ReadKey();
        }

        public static void MoveSnake(object state) {
                switch (direction)
                {
                    case Direction.up:
                        Game.snake.Move(0, -1);
                        break;
                    case Direction.down:
                        Game.snake.Move(0, 1);
                        break;
                    case Direction.left:
                        Game.snake.Move(-1, 0);
                        break;
                    case Direction.right:
                        Game.snake.Move(1, 0);
                        break;
                }
                Game.Draw();
        }
        public static void GameOver()
        {
            Console.Clear();
            Console.SetCursorPosition(20, 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Game Over!");
            Game.isActive = false;
        }
    }
}
