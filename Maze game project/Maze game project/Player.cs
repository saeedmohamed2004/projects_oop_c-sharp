using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_game_project
{
    internal class Player : IMazeobject
    {
        public int X { get; set; }//احداثيات 
        public int Y { get; set; }

        public char icon { get => '@'; }
        public bool Issolid { get =>true;  }
    }
}
