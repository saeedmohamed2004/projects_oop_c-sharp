using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_game_project
{
    public class Maze
    {

        private int _Width;
        private int _Height;
        private Player _Player;
        private IMazeobject[,] MazeobjectsArray;

        public Maze(int width, int height)
        {
            _Width = width;
            _Height = height;
            MazeobjectsArray = new IMazeobject[width, height];
            _Player = new Player()
            {
                X = 1,
                Y = 1,
            };
        }

        public void DrawMaze()
        {
            Console.Clear();
            for (int y = 0; y < _Height; y++)
            {
                for (int x = 0; x< _Width; x++)
                {
                    if (x==39&&y==18 )
                    {
                        MazeobjectsArray[x, y] = new Emptyspace();

                        Console.Write(MazeobjectsArray[x, y].icon);


                    }
                    if (x == 0 || y == 0 || x == _Width -1 || y == _Height-1)//walls
                    {
                        MazeobjectsArray[x, y] = new Wall();
                        Console.Write(MazeobjectsArray[x, y].icon);
                    }
                    else if (x ==_Player.X && y ==_Player.Y)//player
                    {
                        Console.Write(_Player.icon);

                    }
                    else if (x%3==0&&y%3==0)
                    {
                        MazeobjectsArray[x, y] = new Wall();
                        Console.Write(MazeobjectsArray[x, y].icon);
                    }
                    else if (x % 5 == 0 && y % 5== 0)
                    {
                        MazeobjectsArray[x, y] = new Wall();
                        Console.Write(MazeobjectsArray[x, y].icon);
                    }
                    else//emptyspace
                    {
                        MazeobjectsArray[x,y] = new Emptyspace();

                        Console.Write(MazeobjectsArray[x, y].icon);


                    }


                }
                Console.WriteLine();
            }
        }
        public void Moveplayer()
        {
            ConsoleKeyInfo userinput = Console.ReadKey();

            ConsoleKey key = userinput.Key;

            switch (key)
            {
                case ConsoleKey.UpArrow:
                    UpdatePlayer(0,-1);
                    break;
                case ConsoleKey.DownArrow:
                    UpdatePlayer(0, 1);

                    break;
                case ConsoleKey.LeftArrow:
                    UpdatePlayer(-1, 0);

                    break;
                case ConsoleKey.RightArrow:
                    UpdatePlayer(1, 0);

                    break;
            }
        }

        private void UpdatePlayer(int dx, int dy)
        {
            int newX = _Player.X + dx;
            int newY = _Player.Y + dy;

            

            if (newX < _Width && newX>=0 && newY<_Height && newY >= 0 && MazeobjectsArray[newX,newY].Issolid==false) 
            {
                _Player.X = newX;
                _Player.Y = newY;
                DrawMaze();
            }

        }
    }
}
