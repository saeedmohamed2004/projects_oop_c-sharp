namespace Maze_game_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to maze game!");

            Console.WriteLine("use keybord arrow to move the player ");

            Maze maze = new Maze(40,20);

           

            while (true) 
            {
                maze.DrawMaze();
                maze.Moveplayer();
            }




        }
    }
}
