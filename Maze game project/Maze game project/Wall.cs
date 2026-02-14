using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_game_project
{
    internal class Wall : IMazeobject
    {
        public char icon { get => '#';  }
        public bool Issolid { get => true; }
    }
}
