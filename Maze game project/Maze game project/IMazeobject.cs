using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_game_project
{
    public interface IMazeobject
    {
        char icon { get; }//the shape of maze objrct
        bool Issolid {  get; } //movmentblock
    }
}
